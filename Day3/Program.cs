using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserList list = new UserList();
                //1.cikliski vaicaa pievienot lietotajus
                while (true)
                {
                    try
                    {
                        //ievada vardu
                        string name = GetText();
                        //ievada datumu (datetime.tryparse)

                        DateTime birthDate = GetDate();
                        //1.3.ievada dzimumu (enum.tryparse)

                        UserProfile.Genders gender = GetGender();
                        //izsauc lietotaja pievienoshanu ar augstakminetajaam vertibam

                        list.Add(name, gender, birthDate);
                        Console.WriteLine("add another? (y/n): ");
                        string input = Console.ReadLine().ToLower();
                        if(input == "n")
                        {
                            break;
                        }
                    }
                    catch (InputException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("unexpected error! {0}", ex.Message);
            }

            Console.Read();

            }

            public static DateTime GetDate()
            {
                Console.Write(" enter date: ");
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out DateTime date))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine(" invalid date");
                    return GetDate();
                }
            }

            public static string GetText()
            {
                Console.Write(" enter name: ");
                string name = Console.ReadLine();
                name = name.Trim();

                if (!String.IsNullOrEmpty(name))
                {
                    return name;
                }
                else
                {
                    Console.WriteLine(" empty text");
                    return GetText();
                }
            }
            public static UserProfile.Genders GetGender()
            {
                Console.Write(" enter gender: ");
                string value = Console.ReadLine();

                if (Enum.TryParse(value, true, out UserProfile.Genders gender))
                {
                    return gender;
                }
                else
                {
                    Console.WriteLine("incorrect value");
                    return GetGender();
                }
            }
        }
    }


//japievieno try catch