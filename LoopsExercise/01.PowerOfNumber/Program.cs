namespace _01.PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberP = int.Parse(Console.ReadLine());

            int result = 1;
            for (int start = 1; start <= numberP; start++)
            {
                result *= numberN ;
            }
            Console.WriteLine(result);
        }
    }
}
