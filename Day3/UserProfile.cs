using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class UserProfile
    {

        public enum Genders

        {
            Male,

            Female     
        }
        public string FullName { get; set; }
        public Genders Gender { get; set; }

        public DateTime BirthDate { get; set; }
        public UserProfile(string fullName, DateTime birthDate, Genders gender)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public int Age()
        {
            //te ir cits variants no googles
            var age = (DateTime.Now - BirthDate).TotalDays;
            return (int)age / 365;
            
        }
    }
}
