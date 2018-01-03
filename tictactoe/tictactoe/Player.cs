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
            if (num == 1)
            {
                pnum1 = "○";
                pnum2 = "Ｘ";
            }
            else
            {
                pnum1 = "Ｘ";
                pnum2 = "○";
            }
        }
        public void play1()
        {
            Console.Clear();
            grid();
            winner();
            int choice;
            Console.WriteLine("< Player 1's turn >");
            Place:
            Console.Write("Please select the number to place>> ");
            choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 9)
            {
                Console.WriteLine("Select again..");
                goto Place;
            }
            arr[choice-1] = pnum1;
        }

        public void play2()
        {
            Console.Clear();
            grid();
            winner();
            int choice;
            Console.WriteLine("< Player 2's turn >");
            Place:
            Console.Write("Please select the number to place>> ");
            choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 9)
            {
                Console.WriteLine("Select again..");
                goto Place;
            }
            arr[choice-1] = pnum2;
        }
    }
}

