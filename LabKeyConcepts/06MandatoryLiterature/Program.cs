namespace _06MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerOneHour = int.Parse(Console.ReadLine());
            int numberOfDaysPerBook = int.Parse(Console.ReadLine());

            int totalHoursNeeded = numberOfPages / pagesPerOneHour;
            double hoursPerDay = totalHoursNeeded / numberOfDaysPerBook;

            Console.WriteLine(hoursPerDay);
        }
    }
}
