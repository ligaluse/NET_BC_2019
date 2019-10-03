using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public abstract class BasePlayer : IPlayer
    {
        public string Name();
        public int CurrentGuess();
        public bool IsNumberGuessed(int number);
        public abstract string GetName();
    }
}
