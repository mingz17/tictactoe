using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Play
    {
        View view = new View();
        Player player = new Player();
        Com com = new Com();

        public void com_mode()
        {
            int flag = 0;
            com.mode();
            com.select();
            while (flag != 1 || flag != -1)
            {
                com.play();
                flag = com.winner();
                com.com_play();
                flag = com.winner();

            }

            if (flag == 1)  //while 문에
            {
                com.print_win();
            }
            else
                Console.WriteLine("\tDraw !");
            Console.Write("\tIf you want to go back MENU, please enter 'm'key");
        }

        public void player_mode()
        {
            int flag = 0;
            player.mode();
            player.select();
            while (flag != 1 || flag != -1)
            {
                if (player.num == 1) {
                    player.play1();
                    flag = player.winner();
                    player.play2();
                    flag = player.winner();
                }
                else
                {
                    player.play2();
                    flag = player.winner();
                    player.play1();
                    flag = player.winner();
                }
            }

            if (flag == 1)
            {
                com.print_win();
            }
            else
                Console.WriteLine("\tDraw !");
            Console.Write("\tIf you want to go back MENU, please enter 'm'key");
        }

        public void menu()
        {
            Console.WriteLine("\n\n\t\t\t『 Tic Tac Toe 』");
            Console.WriteLine("\n\t\t1) vs Com");
            Console.WriteLine("\n\t\t2) vs Player");
            Console.WriteLine("\n\t\t3) View Score");
            Console.WriteLine("\n\t\t4) Exit");
            //Console.WriteLine("\t   --------------------------------------------");
            Input:
            Console.Write("\n\t Please enter menu number >> ");

            int select_mode;
            select_mode = int.Parse(Console.ReadLine());
            switch (select_mode)
            {
                case 1: com_mode(); break;
                case 2: player_mode(); break;
                case 3: Console.Clear(); player.viewScore(); com.viewScore(); break;
                case 4: return;
                default: Console.WriteLine("Select again.."); goto Input;
            }
        }

       
        /*
        public void mode()
        {
            Console.Clear();
            int num;
            Console.WriteLine("player 1 : ○");
            Console.WriteLine("player 2 : Ｘ");
            Player:
            Console.Write("Please select player number >> ");
            num = int.Parse(Console.ReadLine());
            if (num != 1 && num != 2)
            {
                Console.WriteLine("Select again..");
                goto Player;
            }
            if (num == 1)
            {
                player.pnum1 = "○";
                player.pnum2 = "Ｘ";
                com.pnum = "○";
                com.cnum = "Ｘ";
                play1();
            }
            else
            {
                player.pnum1 = "Ｘ";
                player.pnum2 = "○";
                com.pnum = "Ｘ";
                com.cnum = "○";
                
            }
           
        }
        */
    }
}
