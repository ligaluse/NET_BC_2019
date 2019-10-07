using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class UserList
    {
        private List<UserProfile> users
    }

    public void Add(string fullName, UserProfile.Genders gender, DateTime date)
    {
        //datums nedrikst but nakotne
        DateTime current = DateTime.Now;
        if (date> current)
        {
            throw new InputException("cannot been born in future");
        }
        //datums nedrikst but mazaks par 01.01.1800
        DateTime TooOld = new DateTime(01,01,1800);
        if (date< TooOld)
        {
            throw new InputException("you are too old, sorry ");
        }
        //pilnais vards nedrikst parniegt 20 simbolus
        if (fullName.Length >20 )
        {
            throw new InputException("your name is too long");
        }
        //lietotaja izveide
        UserProfile user = new UserProfile(fullName, date, gender);
        user.Add(user);
    }
}
}
