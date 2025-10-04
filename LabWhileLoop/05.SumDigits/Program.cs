namespace _05.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            // while - loop
            //1. Повтаряме - взимаме последната цифра, сумираме, премахваме
            //2. Стоп: нямаме повече цифри в числото (число == 0)
            //3. Продължаваме: има все още цифри в числото (число != 0)

            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number = number / 10; //number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
