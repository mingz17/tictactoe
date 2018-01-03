using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Com : View
    {
        public void select()
        {
            if (num == 1)
            {
                pnum = "○";
                cnum = "Ｘ";
            }
            else
            {
                pnum = "Ｘ";
                cnum = "○";
            }
        }

        Random rnd = new Random();
        public void play()
        {
            Console.Clear();
            grid();
            int choice;
            Console.WriteLine("< Player's turn >");
            Place:
            Console.Write("Please select the number to place>> ");
            choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 9)
            {
                Console.WriteLine("Select again..");
                goto Place;
            }
            if (arr[choice-1].Equals("○") || arr[choice-1].Equals("Ｘ"))
            {
                Console.WriteLine("Already selected..Select again");
                goto Place;
            }

            arr[choice-1] = pnum;

        }
        public void com_play()
        {
            Console.Clear();
            grid();
            int com_choice;
            Console.WriteLine("< Computer's turn >");
            Random:
            com_choice = rnd.Next(0, 9);
            if (arr[com_choice].Equals("○") || arr[com_choice].Equals("Ｘ"))
                goto Random;
            arr[com_choice] = cnum;
            System.Threading.Thread.Sleep(2000);
            
        }

        public override void print_win(int i)
        {
            if (arr[i].Equals(pnum))
            {
                Console.WriteLine("Player is Win");
                p_score++;
            }
            else
            {
                Console.WriteLine("Computer is Win");
                com_score++;
            }
        }


    }
}
