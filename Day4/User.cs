using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class User : BasePlayer
    {
        //override taapeec, ka njemam info no baseplayer, kas ir abstrakta kluuda
      public override string GetName()
        {
            if(!String.IsNullOrEmpty(Name))
            {
                return Name;
            }
            
            return ConsoleInput.GetText("enter your name: ");
           
        }
        public override int GuessNumber()
        {
            CurrentGuess = ConsoleInput.GetInt("enter your guess : ");
            return CurrentGuess;
        }

       

    }
}