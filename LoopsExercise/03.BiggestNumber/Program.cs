using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue; //we start with the smallest number possible

            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number > maxNumber)
                {
                    maxNumber = number; // we update maxNumber
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
