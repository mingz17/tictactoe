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
                if (flag == 1 || flag == -1)
                {
                    com.board();
                    break;
                }
                com.com_play();
                flag = com.winner();
                if (flag == 1 || flag == -1)
                {
                    com.board();
                    break;
                }
            }

            if (flag == 1)  //while 문에
            {
                com.print_win();
            }
            else
                Console.WriteLine("\tDraw !");

            com.computeScore();
            Console.Write("\n\tIf you want to go back MENU, please enter【 M 】key... ");
            String input = Console.ReadLine();
            if (input == "m" || input == "M")
            {
                com.reset();
                menu();
            }
            else return;
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
                    Console.WriteLine();
                    if (flag == 1 || flag == -1)
                    {
                        player.board();
                        break;
                    }
                    player.play2();
                    flag = player.winner();
                    if (flag == 1 || flag == -1)
                    {
                        player.board();
                        break;
                    }
                }
                else
                {
                    player.play2();
                    flag = player.winner();
                    if (flag == 1 || flag == -1)
                    {
                        player.board();
                        break;
                    }
                    player.play1();
                    flag = player.winner();
                    if(flag == 1 || flag == -1)
                    {
                        player.board();
                        break;
                    }
                }
            }

            if (flag == 1)
            {
                player.print_win();
            }
            else
                Console.WriteLine("\tDraw !");

            player.computeScore();
            Console.Write("\n\tIf you want to go back MENU, please enter【 M 】key... ");
            String input = Console.ReadLine();
            if (input == "m" || input == "M")
            {
                player.reset();
                menu();
            }
            else return;
        }

        public void menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\t\t\t『 Tic Tac Toe 』");
            Console.ForegroundColor = ConsoleColor.White;
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
                case 3: {
                        Console.Clear(); com.com_viewScore();
                        Console.Write("\n\n\n\n"); player.player_viewScore();
                        Console.Write("\n\n\n\tIf you want to go back MENU, please enter【 M 】key... ");
                        String input = Console.ReadLine();
                        if (input == "m" || input == "M")
                            menu();
                        else return;
                        break;
                    }
                case 4: return;
                default: Console.WriteLine("\tSelect again.."); goto Input;
            }
        }

        /*
        public void reset()
        {
            player.pnum1 = null; player.pnum2 = null;
            player.arr[0] = "⑴"; player.arr[1] = "⑵";
            player.arr[2] = "⑶"; player.arr[3] = "⑷";
            player.arr[4] = "⑸"; player.arr[5] = "⑹";
            player.arr[6] = "⑺"; player.arr[7] = "⑻";
            player.arr[8] = "⑼";
        }
        */
    }
}
