using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int num1 = GetNumber("exter number a");
                int num2 = GetNumber("exter number b");

                Console.WriteLine("division= {0}",
                    Calculator.Divide(num1, num2));
                               
            }

            catch(CalculatorException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(Exception)
            {
                Console.WriteLine("neparedzeta kluda");
            }
            
            Console.Read();
        }

        static int GetNumber(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();

         //   if(int.TryParse(input, out int result))
          //  {
         //       return result;
        //    }

            try
            {
                int result = int.Parse(input);
                return result;
            }
            catch(Exception)
            {
                Console.WriteLine("invalid number" );
                return GetNumber(text);
            }
        }
    }
}
