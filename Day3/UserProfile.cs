using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class UserProfile
    {
        string FullName;
        enum Gender
        {
            m,
            f
        }
        DateTime dateOfBirth;
    }

    public static int CalculateAge(DateTime dateOfBirth)
    {
        int age = 0;
        age = DateTime.Now.Year - dateOfBirth.Year;
        return age;
    }
}
