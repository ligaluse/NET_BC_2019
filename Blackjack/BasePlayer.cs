using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public abstract class BasePlayer : IBlackjackPlayer
    {
        protected string Name { get; set; }

        public abstract string GetName();
        protected List<Card>Cards { get; set; }
        
         public BasePlayer()
        {
            Cards = new List<Card>();
            Name = GetName();
        }
        public List<Card> GetCards()
        {
            return Cards;
        }
       
        public int CountPoints()
        {
            //jeb iisaak int points = Cards.Sum(c=>c.GetPoints());
            int points = 0;
            foreach(Card card in Cards)
            {
                points += card.GetPoints();
            }
            if(points > 21)
            {
                int aceCount = Cards.Count(c => c.GetPoints() == 11);
                while(aceCount > 0 && points > 21)
                {
                    points = points - 10;
                    aceCount--;
                }

            }
            return points;
        }
        public virtual bool IsGameCompleted()
        {
            if (CountPoints() >= 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            //jeb īsāk return CountPoints() > 21
       
       public virtual void GiveCard(Card card)
        {
           
            Cards.Add(card);
        }
        public abstract bool WantCard();
        
    }
}
