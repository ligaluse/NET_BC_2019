﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Robot : BasePlayer
    {
        public abstract string GetName();
        public int GuessNumber();
    }
}