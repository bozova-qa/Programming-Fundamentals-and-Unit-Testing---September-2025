namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}
