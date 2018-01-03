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
        /*
        public void start()
        {
            
            View view = new View();
            view.menu();
            Console.Clear();
            
            menu();

        }
        */
        public void com_mode()
        {
            com.mode();
            com.select();
            while (true)
            {
                com.play();
                com.winner();
                draw();
                com.com_play();
                com.winner();
                if (com.flag == true)
                    break;
            }
            Console.Write(""); //메뉴로 돌아가시겠?
        }

        public void player_mode()
        {
            player.mode();
            player.select();
            while (true)
            {
                player.play1();
                player.winner();
                player.play2();
                player.winner();
                if (player.flag == true)
                    break;
            }
        }
        public void menu()
        {
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("1) vs Com");
            Console.WriteLine("2) vs Player");
            Console.WriteLine("3) View Score");
            Console.WriteLine("4) Exit");
            Input:
            Console.Write("Please enter menu number >> ");

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

        public void draw()
        {
            int cnt = 0;
            for (int i = 0; i < 9; i++)
            {
                if (com.arr[i].Equals("○") || com.arr[i].Equals("Ｘ"))
                {
                    cnt++;
                }
            }
            if (cnt == 9)
            {
                Console.WriteLine("Draw !");
              //  goto Out;
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
