using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public interface IPlayer
    {
        //intefeisaa fjas nav jaliek ne ar public, ne ar ko
        int GuessNumber();
        bool IsNumberGuessed(int number);
        string GetName();
    }
}