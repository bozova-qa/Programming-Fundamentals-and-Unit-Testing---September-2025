namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;

            while (input != "End")
            {
                double deposit = double.Parse(input);
                
                if (deposit > 0)
                {
                    Console.WriteLine($"Increase: {deposit:F2}");
                }
                else
                {
                    Console.WriteLine($"Decrease: {Math.Abs(deposit):F2}");
                }

                balance += deposit;
                input = Console.ReadLine(); // we update input here, not deposit! while condition updates too
            }
            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}
