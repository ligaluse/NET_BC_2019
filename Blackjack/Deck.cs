using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class Deck
    {
        //4 masti
        string[] suits = new[] { "C", "S", "D", "H" };
        //13 rangi
        string[] ranks = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J" };
        List<Card> Cards;
        
        public Deck()
        {
            Cards = new List<Card>();
            foreach(string suit in suits)
            {
                foreach(string rank in ranks)
                {
                    Cards.Add(new Card(rank, suit));
                }
            }
        }
       //randomly orders (shuffles) the list of cards
           public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList();
        }

        public Card GetCard()
        {
            var Card = Cards.Last();
            Cards.Remove(Card);
            return Card;
        }
    }
}
