using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class UserList
    {
        //šīs nav pabeigts!!!!
        private List<UserProfile> users = new List<UserProfile>();


        public void Add(string fullName, UserProfile.Genders gender, DateTime date)
        {
            //datums nedrikst but nakotne

            if (date > DateTime.Now)
            {
                throw new InputException("cannot been born in future");
            }
            //datums nedrikst but mazaks par 01.01.1800

            if (date < new DateTime(1800, 1, 1))
            {
                throw new InputException("you are too old, sorry ");
            }
            //pilnais vards nedrikst parniegt 20 simbolus
            if (fullName.Length > 20)
            {
                throw new InputException("your name is too long");
            }
            //lietotaja izveide
            UserProfile user = new UserProfile(fullName, date, gender);
            users.Add(user);

            Console.WriteLine("user with age {0} added!", user.Age());
        }
    }
}

