﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class User : BasePlayer
    {
        public abstract string GetName();
        public int GuessNumber();

    }
}
