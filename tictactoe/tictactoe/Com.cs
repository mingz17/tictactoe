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
            //Console.Clear();
            board();
            int choice;
            Console.WriteLine("\t《 Player's turn 》");
            Place:
            Console.Write("\n\tPlease select the number to place >> ");
            choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 9)
            {
                Console.WriteLine("\tSelect again..");
                goto Place;
            }
            if (arr[choice-1].Equals("○") || arr[choice-1].Equals("Ｘ"))
            {
                Console.WriteLine("\tAlready marked..Select again");
                goto Place;
            }

            arr[choice-1] = pnum;

        }
        public void com_play()
        {
            //Console.Clear();
            board();
            int com_choice;
            Console.WriteLine("\t《 Computer's turn 》");
            Random:
            com_choice = rnd.Next(0, 9);
            if (arr[com_choice].Equals("○") || arr[com_choice].Equals("Ｘ"))
                goto Random;
            arr[com_choice] = cnum;
            System.Threading.Thread.Sleep(2000);
            
        }

        public void print_win()
        {
            if (arr[win].Equals(pnum))
            {
                Console.WriteLine("\tPlayer Win");
                p_score++;
            }
            else
            {
                Console.WriteLine("\tComputer  Win");
                com_score++;
            }
        }

        public void com_viewScore()
        {
            Console.WriteLine("\n\t\t\t     《 Player vs Computer 》");
            Console.WriteLine();
            Console.WriteLine("\t\t\t Player                 Computer            ");
            Console.WriteLine("\t\t==================================================");
            viewScore();
        }
    }
}
