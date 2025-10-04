using System.Security.Cryptography.X509Certificates;

namespace _07.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command == "Inc" || command == "Dec")
            {
                if (command == "Inc") 
                {
                    number++;
                    command = Console.ReadLine();
                }

                if (command == "Dec")
                {
                    --number;
                    command = Console.ReadLine();
                }
                else if (command == "End")
                {
                    break;
                }
            }
            Console.WriteLine(number);
        }
    }
}
