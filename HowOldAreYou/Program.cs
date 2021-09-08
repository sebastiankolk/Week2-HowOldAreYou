using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui vana sa oled?");

            int Age = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - Age;

            Console.WriteLine($"Oled sündinud aastal {YearOfBirth}.");

            Console.Read();
        }
    }
}
