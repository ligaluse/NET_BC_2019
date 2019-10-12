using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public string GetTitle()
        {
            return Suit + Rank;
        }

            
        public int GetPoints()
        {
            switch(Rank)
            {
                case "A":
                    return 11;
                case "K":
                case "Q":
                case "J":
                    return 10;
                default:
                    return int.Parse(Rank);
            }
        }

    }
}
