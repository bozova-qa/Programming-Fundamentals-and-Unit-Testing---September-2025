namespace _01.NumberType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("negative");
            }
            if (number > 0)
            {
                Console.WriteLine("positive");
            }
            if (number == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}
