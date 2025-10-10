using Microsoft.VisualBasic;

namespace _06.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double budgetNeeded = double.Parse(Console.ReadLine());
                double sum = 0;

                while (sum < budgetNeeded) // keep saving until we reach/exceed
                {
                    double savings = double.Parse(Console.ReadLine());
                    sum += savings;
                    Console.WriteLine($"Collected: {sum:F2}");
                }
                Console.WriteLine($"Going to {destination}!");

                //read the next destination
                destination = Console.ReadLine();
            }
        }
    }
}
