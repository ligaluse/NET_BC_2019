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
       if()
        {
            throw new InputException("");
        }
       //datums nedrikst but mazaks par 01.01.1800
       if()
        {
            throw new InputException(" ");
        }
       //pilnais vards nedrikst parniegt 20 simbolus
       if()
        {
            throw new InputException("");
        }
        //lietotaja izveide
        UserProfile user = new UserProfile(fullName, date, gender);
        user.Add(user);
    }
}
