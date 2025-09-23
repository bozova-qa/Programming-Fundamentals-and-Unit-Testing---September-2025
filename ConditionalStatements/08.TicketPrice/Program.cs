using System.Net.Sockets;

namespace _08.TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();

            double studentTicket = 1.00;
            double regularTicket = 1.60;

            if (ticketType == "student")
            {
                Console.WriteLine($"${studentTicket:F2}");
            }
            else if (ticketType == "regular")
            {
                Console.WriteLine($"${regularTicket:F2}");
            }
            else 
            {
                Console.WriteLine("Invalid ticket type!");
            }
       
        }
    }
}
