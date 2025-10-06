namespace _07.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int lastNumber = 0;
            while (true)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (stopNumber == currentNumber)
                {
                    break;
                }
                lastNumber = currentNumber;
            }
            double result = lastNumber * 1.20; // 20%
            Console.WriteLine(result);
        }
    }
}
