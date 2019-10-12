using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player : BasePlayer
    {
        public override string GetName()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }

            return ConsoleInput.GetText("enter your name: ");
        }

        public override bool WantCard()
        {
            return ConsoleInput.GetBool("another card? ");

        }
        public override void GiveCard(Card card)
        {
            base.GiveCard(card);
            Console.WriteLine("you received card {0}", card.GetTitle());
            Console.WriteLine("your points {0}", CountPoints());
        }

    }
}
