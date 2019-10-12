using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                game.StartNewGame();
                game.Loop();
                if(!ConsoleInput.GetBool("play again?"))
                {
                    Environment.Exit(0);
                    break;
                }
            }

                Console.Read();
            
        }
    }
}
