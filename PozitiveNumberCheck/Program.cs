using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozitiveNumberCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please Enter The Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("This Number is Positive");
            }
            else
            {
                Console.WriteLine("This Number is Negative");
            }
            Console.ReadKey();
        }
    }
}
