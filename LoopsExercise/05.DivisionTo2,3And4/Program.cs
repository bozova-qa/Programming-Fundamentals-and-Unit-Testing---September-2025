using System.Diagnostics.CodeAnalysis;

namespace _05.DivisionTo2_3And4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            for (int i = 1; i <= number; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                if (newNumber % 2 == 0)
                {
                    sum2 += 1;
                }
                if (newNumber % 3 == 0)
                {
                    sum3 += 1;
                }
                if (newNumber % 4 == 0)
                {
                    sum4 += 1;
                }

            }

            double percentTwo = (sum2 * 100.0) / number;
            double percentThree = (sum3 * 100.0) / number;
            double percentFour = (sum4 * 100.0) / number;

            Console.WriteLine($"{percentTwo:F2}%");
            Console.WriteLine($"{percentThree:F2}%");
            Console.WriteLine($"{percentFour:F2}%");
        }
    }
}
