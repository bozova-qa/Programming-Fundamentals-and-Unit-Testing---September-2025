namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            if (typeOfMovie == "Premiere")
            {
                double totalPrice = 12.00 * rows * seats;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (typeOfMovie == "Normal")
            {
                double totalPrice = 7.50 * rows * seats;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (typeOfMovie == "Discount")
            {
                double totalPrice = 5.00 * rows * seats;
                Console.WriteLine($"{totalPrice:F2}");
            }
        }
    }
}
