namespace _08.PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //прости числа - имат точно два делителя
            //съставни - имат повече от един делител

            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            // преминаваме през всички числа в диапазона startNumber - endNumber
            for (int number = startNumber; number <= endNumber; number++)
            {
                //проверка дали е просто число
                int countDivisors = 0;
                for (int i = 1; i <= number;i++)// for-loop, който да обходи всички числа от 1 до number; ako се дели без остатък, да преброи
                {
                    if (number % i == 0)
                    {
                        countDivisors++;
                    }
                }

                //вече знаем броя на делителите
                if (countDivisors == 2) 
                {
                    Console.Write(number + " ");//отпечатваме ако е просто
                }
            }
        }
    }
}
