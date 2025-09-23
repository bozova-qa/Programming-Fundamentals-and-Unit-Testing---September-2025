namespace _01ConvertorUSDToEUR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double dollarsToEuro = dollars * 0.88;
            
            Console.WriteLine($"{dollarsToEuro:F2}");
        }
    }
}
