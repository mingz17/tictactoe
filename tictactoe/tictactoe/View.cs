using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class View
    {
        public String pnum1, pnum2, pnum, cnum ;
        public String[] arr = new String[] { "⑴", "⑵", "⑶", "⑷", "⑸", "⑹", "⑺", "⑻", "⑼" };
        public int num;
        public Boolean flag = false;

        public void mode()
        {
            Console.Clear();
            
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
            /*
            if (num == 1)
            {                
                Com com = new Com();
                com.select();
            }
            else
            {
                {
                    Player player = new Player();
                    player.select();
                }
            }
            */
        }
        public void grid()
        {
            Console.WriteLine("\r\t        │        │");
            Console.WriteLine("\r\t   {0}   │   {1}   │   {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("\r\t ───────│────────│───────");
            Console.WriteLine("\r\t   {0}   │   {1}   │   {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("\r\t ───────│────────│───────");
            Console.WriteLine("\r\t   {0}   │   {1}   │   {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("\r\t        │        │");
            Console.WriteLine("\r\n");
            
        }

        public int p1_score = 0, p2_score = 0, p_score=0, com_score = 0;
        public void winner()
        {
            if (arr[0].Equals(arr[1]) && arr[1].Equals(arr[2])) //가로
            {
                print_win(0);
            }
            else if (arr[3].Equals(arr[4]) && arr[4].Equals(arr[5]))
            {
                print_win(3);
            }
            else if (arr[6].Equals(arr[7]) && arr[7].Equals(arr[8]))
            {
                print_win(6);
            }
            else if (arr[0].Equals(arr[3]) && arr[3].Equals(arr[6])) //세로
            {
                print_win(0);
            }
            else if (arr[1].Equals(arr[4]) && arr[4].Equals(arr[7]))
            {
                print_win(1);
            }
            else if (arr[2].Equals(arr[5]) && arr[5].Equals(arr[8]))
            {
                print_win(2);
            }
            else if (arr[0].Equals(arr[4]) && arr[4].Equals(arr[8])) //대각선
            {
                print_win(4);
            }
            else if (arr[2].Equals(arr[4]) && arr[4].Equals(arr[6]))
            {
                print_win(4);
            }
        }
        public virtual void print_win(int i)
        {
            if (arr[i].Equals(pnum1))
            {
                Console.WriteLine("Player 1 is Win");
                p1_score++;
            }
            else
            {
                Console.WriteLine("Player 2 is Win");
                p2_score++;
            }
            flag = true;
        }

        
        public void viewScore()
        {
            List<int> array = new List<int>();
            array.Add(p1_score);
            array.Add(p2_score);
            ArrayList list = new ArrayList(array);

            Console.WriteLine("Player1 vs Player2");
            Console.WriteLine();
            Console.WriteLine(" Player 1               Player 2            ");
            Console.WriteLine("==============================================");

            foreach (object item in list)
            {
                if (list.Contains(item))
                {

                }
                else
                    Console.WriteLine("?"); //값 존재하지 않
            }
        }
    }
}

