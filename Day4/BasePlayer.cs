using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public abstract class BasePlayer : IPlayer
    {
        public string Name();
        public int CurrentGuess();
        public bool IsNumberGuessed(int number);
        public abstract string GetName();
    }
}