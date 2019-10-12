using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
     public class Game
    {
        private IBlackjackPlayer PlayerOne;
        private IBlackjackPlayer PlayerTwo;
        private Deck Deck;
        public void StartNewGame()
        {
            PlayerOne = new Player();
            PlayerTwo = new Dealer();
            Deck = new Deck();
            Deck.Shuffle();
            PlayerOne.GiveCard(Deck.GetCard());
            PlayerOne.GiveCard(Deck.GetCard());
            PlayerTwo.GiveCard(Deck.GetCard());
            PlayerTwo.GiveCard(Deck.GetCard());

        }

        
        public void Loop()
        {

                while(!PlayerOne.IsGameCompleted() && PlayerOne.WantCard())
            {
                PlayerOne.GiveCard(Deck.GetCard());
            }
            if (PlayerOne.CountPoints() > 21)
            {
                Console.WriteLine("you lose");
            }
            else if(PlayerOne.CountPoints()== 21)
            {
                Console.WriteLine("you win");
            }
            else
            {
                Console.WriteLine("dealer turn");
                while (!PlayerTwo.IsGameCompleted() && PlayerTwo.WantCard())
                {
                    PlayerTwo.GiveCard(Deck.GetCard());
                }
                if (PlayerTwo.CountPoints() > 21)
                {
                    Console.WriteLine("dealer lose");
                }
                int playerPoints = PlayerOne.CountPoints();
                int dealerPoints = PlayerTwo.CountPoints();
                Console.WriteLine("your points {0}", playerPoints);
                Console.WriteLine("dealer points {0}", dealerPoints);


                
                //if(dealerPoints > 21 || playerPoints> dealerPoints)
                //{
                //    Console.WriteLine("player wins");
                //}
                //else
                //{
                //    Console.WriteLine("player lose");
                //}
                Console.WriteLine(dealerPoints > 21 || playerPoints> dealerPoints ? "you win" : "you lose");


            }

        }
    }
}
