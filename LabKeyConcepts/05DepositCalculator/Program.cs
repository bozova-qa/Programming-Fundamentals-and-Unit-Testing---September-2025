namespace _05DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double accumulatedInterest = depositedAmount * annualInterestRate / 100;
            double interestPerMonth = accumulatedInterest / 12;
            double totalAmount = depositedAmount + depositMonths * interestPerMonth;

            Console.WriteLine(totalAmount);
        }
    }
}
