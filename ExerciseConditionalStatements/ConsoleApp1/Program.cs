namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accomodation = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            if (season == "Spring") { 
                if (accomodation == "Hotel")
                {
                    double totalCost = days * 30.00 - (days * 30.00) * 0.20;
                    Console.WriteLine($"{totalCost:F2}");
                }
                else if (accomodation == "Camping")
                {
                    double totalCost = days * 10.00 - (days * 10.00) * 0.20;
                    Console.WriteLine($"{totalCost:F2}");
                }
            }
            else if (season == "Summer")
            {
                if (accomodation == "Hotel")
                {
                    double totalCost = days * 50.00;
                    Console.WriteLine($"{totalCost:F2}");
                }
                else if (accomodation == "Camping")
                {
                    double totalCost = days * 30.00;
                    Console.WriteLine($"{totalCost:F2}");
                }
            }
            else if (season == "Autumn")
            {
                if (accomodation == "Hotel")
                {
                    double totalCost = days * 20.00 - (days * 20.00) * 0.30;
                    Console.WriteLine($"{totalCost:F2}");
                }
                else if (accomodation == "Camping")
                {
                    double totalCost = days * 15.00 - (days * 15.00) * 0.30;
                    Console.WriteLine($"{totalCost:F2}");
                }
            }
            else if (season == "Winter")
            {
                if (accomodation == "Hotel")
                {
                    double totalCost = days * 40.00 - (days * 40.00) * 0.10;
                    Console.WriteLine($"{totalCost:F2}");
                }
                else if (accomodation == "Camping")
                {
                    double totalCost = days * 10.00 - (days * 10.00) * 0.10;
                    Console.WriteLine($"{totalCost:F2}");
                }
            }
        }
    }
}
