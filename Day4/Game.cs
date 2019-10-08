using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Game
    {
        //private jo nav paredzets mainishanai. tas var sabjat speles logjiku,ja butu public
        private int CurrentNumber;
        private IPlayer PlayerOne;
        private IPlayer PlayerTwo;

        public void StartNewGame()
        {
            Random rnd = new Random();
            CurrentNumber = rnd.Next(501);

            PlayerOne = new User();
            PlayerTwo = new Robot();
        }
        public void Loop()
        {
            while (true)
            {
                // playerone guesses the number
                // PlayerTurn(PlayerOne);
                // jeb PlayerOne.GuessNumber();
                //if correct, break the loop and player 1 wins
                //   if (PlayerOne.IsNumberGuessed(CurrentNumber))
                //  {
                //      Console.WriteLine("player 1 wins");
                //       break;
                //  }
                //kompja gaajiens:
                //  PlayerTurn(PlayerTwo);
                // PlayerTwo.GuessNumber();
                //  if (PlayerTwo.IsNumberGuessed(CurrentNumber))
                // {
                //     Console.WriteLine("player 2 wins");
                //      break;
                //  }
                //jeb:
                Console.WriteLine("player 1 turn: ");
            if(PlayerTurn(PlayerOne))
                {
                    break;
                }
                Console.WriteLine("player 2 turn: ");
                if (PlayerTurn(PlayerTwo))
                {
                    break;
                }

            }
           
        }
        private bool PlayerTurn(IPlayer player)
        {
            player.GuessNumber();
            bool isGuessed = player.IsNumberGuessed(CurrentNumber);
            if(isGuessed)
            {
                Console.WriteLine("player {0} wins", player.GetName());
            }
            return isGuessed;
        }
    }
}
