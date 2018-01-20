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
            Console.Write("\n\n\tPlease select player number >> ");
            num = int.Parse(Console.ReadLine());
            if (num != 1 && num != 2)
            {
                Console.WriteLine("\tSelect again..");
                goto Player;
            }
        }

        public void board()
        {
            Console.Clear();
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
        public int win; //이긴사람
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
            else if (arr[0] != "⑴" && arr[1] != "⑵" && arr[2] != "⑶" && arr[3] != "⑷" && arr[4] != "⑸" && arr[5] != "⑹" && arr[6] != "⑺" && arr[7] != "⑻" && arr[8] != "⑼")
            {
                return -1;
            }
            else return 0;
        }

        List<String> score = new List<String>();
        public void computeScore()
        {
            int flag = winner();
            if (flag == -1)
            {
                score.Add("Draw");
                score.Add("Draw");
            }

            else if (arr[win].Equals(pnum1)|| arr[win].Equals(pnum))
            {
                score.Add("Win");
                score.Add("Lose");

            }
            else if (arr[win].Equals(pnum2)||arr[win].Equals(cnum))
            {
                score.Add("Lose");
                score.Add("Win");
            }
        }
        
        public void viewScore()
        {
            /*
            Console.WriteLine("\t\t\t       Player1 vs Player2");
            Console.WriteLine();
            Console.WriteLine("\t\t\t Player 1               Player 2            ");
            Console.WriteLine("\t\t=================================================");
            */
            int chk = 0;
            foreach (object item in score)
            {
                if (chk % 2 == 0&&chk!=0)
                    Console.Write("\n\n");
                if (score.Contains(item))
                {
                    Console.Write("\t\t\t  {0}",item);
                    chk++;
                }
                else
                    Console.WriteLine("value does not exist.."); 
            }
            
        }

        public void reset()
        {
            pnum1 = null; pnum2 = null;
            pnum = null; cnum = null;
            arr[0] = "⑴"; arr[1] = "⑵";
            arr[2] = "⑶"; arr[3] = "⑷";
            arr[4] = "⑸"; arr[5] = "⑹";
            arr[6] = "⑺"; arr[7] = "⑻";
            arr[8] = "⑼";
        }
    }
}

