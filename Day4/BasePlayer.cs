using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public abstract class BasePlayer : IPlayer
    {

        //abstraktajās klasēs īpašības liek protected
        protected string Name;
        protected int CurrentGuess;
        protected int NextGuess;

        public abstract string GetName();
        public abstract int GuessNumber();
        public virtual bool IsNumberGuessed(int number)
        {
            if(number> CurrentGuess)
            {
                Console.WriteLine("{0} is less than number", CurrentGuess);
                NextGuess = 1;
            }
            else if(number< CurrentGuess)
            {
                Console.WriteLine("{0} is greater than number", CurrentGuess);
                NextGuess = -1;
            }

            return number == CurrentGuess;
           
        }
        public BasePlayer()
        {
            Name = GetName();
        }
    }
}