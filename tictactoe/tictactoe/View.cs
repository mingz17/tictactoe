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
        public String pnum1 = null, pnum2 = null, pnum = null, cnum = null;
        public String[] arr = new String[] { "⑴", "⑵", "⑶", "⑷", "⑸", "⑹", "⑺", "⑻", "⑼" };
        public int num;

        public void mode()
        {
            Console.Clear();
            
            Console.WriteLine("\n\n\n\n\n\t\t【 player 1 : ○ 】");
            Console.WriteLine("\n\t\t【 player 2 : Ｘ 】");
            Player:
            Console.Write("\n\tPlease select player number >> ");
            num = int.Parse(Console.ReadLine());
            if (num != 1 && num != 2)
            {
                Console.WriteLine("\tSelect again..");
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
        public void board()
        {
            Console.WriteLine("\n\n\t\t        │        │");
            Console.WriteLine("\t\t   {0}   │   {1}   │   {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("\t\t ───────│────────│───────");
            Console.WriteLine("\t\t   {0}   │   {1}   │   {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("\t\t ───────│────────│───────");
            Console.WriteLine("\t\t   {0}   │   {1}   │   {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("\t\t        │        │");
            Console.WriteLine("\n\n");
            
        }

        public int p1_score = 0, p2_score = 0, p_score=0, com_score = 0;
        public int win;
        public int winner()
        {
            if (arr[0].Equals(arr[1]) && arr[1].Equals(arr[2])) //가로
            {
                win = 0;
                return 1;
            }
            else if (arr[3].Equals(arr[4]) && arr[4].Equals(arr[5]))
            {
                win = 3;
                return 1;
            }
            else if (arr[6].Equals(arr[7]) && arr[7].Equals(arr[8]))
            {
                win = 6;
                return 1;
            }
            else if (arr[0].Equals(arr[3]) && arr[3].Equals(arr[6])) //세로
            {
                win = 0;
                return 1;
            }
            else if (arr[1].Equals(arr[4]) && arr[4].Equals(arr[7]))
            {
                win = 1;
                return 1;
            }
            else if (arr[2].Equals(arr[5]) && arr[5].Equals(arr[8]))
            {
                win = 2;
                return 1;
            }
            else if (arr[0].Equals(arr[4]) && arr[4].Equals(arr[8])) //대각선
            {
                win = 4;
                return 1;
            }
            else if (arr[2].Equals(arr[4]) && arr[4].Equals(arr[6]))
            {
                win = 4;
                return 1;
            }
            else if (arr[0] != null && arr[1] != null && arr[2] != null && arr[3] != null && arr[4] != null && arr[5] != null && arr[6] != null && arr[7] != null && arr[8] != null)
            {
                return -1;
            }
            else return 0;
        }
       
        public void computeScore()
        {

        }
        
        public void viewScore()
        {
            List<String> score = new List<String>();
            if (arr[win].Equals(pnum1))
            {
                score.Add("Win");
                score.Add("Lose");

            }
            else if(arr[win].Equals(pnum2))
            {
                score.Add("Lose");
                score.Add("Win");
            }
            
            ArrayList round = new ArrayList(score);

            Console.WriteLine("\t\t\t       Player1 vs Player2");
            Console.WriteLine();
            Console.WriteLine("\t\t\t Player 1               Player 2            ");
            Console.WriteLine("\t\t=================================================");

            foreach (object item in round)
            {
                if (round.Contains(item))
                {
                    Console.Write("{0}  ",item);
                }
                else
                    Console.WriteLine("value does not exist.."); 
            }
        }
    }
}

