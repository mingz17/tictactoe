using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(50, 50);
            Play play = new Play();
            play.menu();
        }
    }
}
