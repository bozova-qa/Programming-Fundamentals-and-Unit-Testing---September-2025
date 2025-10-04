namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;
            while (number <= n)
            {
                Console.WriteLine(number);// първо трябва да разпечата 1, после да го увеличи
                number = number * 2 + 1;
                
            }
            
        }
    }
}
