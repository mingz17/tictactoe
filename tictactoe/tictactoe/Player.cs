using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Player : View
    {
        public void select()
        {
                pnum1 = "○";
                pnum2 = "Ｘ";       
        }
        
        public void play1()
        {
            //Console.Clear();
            board();
            int choice;
            Console.WriteLine("\t《 Player 1's turn 》");
            Place:
            Console.Write("\n\tPlease select the number to place >> ");
            choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 9)
            {
                Console.WriteLine("\tSelect again..");
                goto Place;
            }
            if (arr[choice - 1].Equals("○") || arr[choice - 1].Equals("Ｘ"))
            {
                Console.WriteLine("\tAlready marked..Select again");
                goto Place;
            }
            arr[choice-1] = pnum1;
        }

        public void play2()
        {
            //Console.Clear();
            board();
            int choice;
            Console.WriteLine("\t《 Player 2's turn 》");
            Place:
            Console.Write("\n\tPlease select the number to place >> ");
            choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 9)
            {
                Console.WriteLine("\tSelect again..");
                goto Place;
            }
            if (arr[choice - 1].Equals("○") || arr[choice - 1].Equals("Ｘ"))
            {
                Console.WriteLine("\tAlready marked..Select again");
                goto Place;
            }
            arr[choice-1] = pnum2;
        }

        public void print_win()
        {
            if (arr[win].Equals(pnum1))
            {
                Console.WriteLine("\tPlayer 1  Win");
                p1_score++;
            }
            else
            {
                Console.WriteLine("\tPlayer 2  Win");
                p2_score++;
            }
        }
    }
}

