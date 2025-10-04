namespace _03.OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //while - read numbers
            //stop condition - n % 2 != 0;
            //continue - n % 2 == 0;
            while (number % 2 == 0) 
            {
                number = int.Parse(Console.ReadLine()); // това, което повтаряме
               
            }
            Console.WriteLine(number);
        }
    }
}
