using System.Globalization;

namespace _07.SumОfDigitsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop
            //повтаряме: въвеждаме данни от конзолата
            //стоп: входни данни == End
            //продължаваме: входни данни != End;

            string input = Console.ReadLine();
            int sum = 0;
            while (input != "End")
            {
                int number = int.Parse(input); //преобразуваме string в число;
                
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;//премахваме последната цифра
                }
                Console.WriteLine($"Sum of digits = {sum}");
                sum = 0;
               
                input = Console.ReadLine();//докато е различно от end, четем данни
            }
            Console.WriteLine("Goodbye");

        }
    }
}
