using System;

namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyNumber = number;
            bool isSpecial = true;

            while (copyNumber > 0) // ако е > 0, значи все още има цифри
            {
                int lastDigit = copyNumber % 10;//взимам последната цифра от числото
                if (number % lastDigit != 0)
                {
                    isSpecial = false;
                    break;
                }
                copyNumber = copyNumber / 10; //премахва последната цифра от числото

            } 
            if (isSpecial) // ако isSpecial e true
            {
                Console.WriteLine($"{number} is special");
            }
            else
            {
                Console.WriteLine($"{number} is not special");
            }
        }
    }
}
