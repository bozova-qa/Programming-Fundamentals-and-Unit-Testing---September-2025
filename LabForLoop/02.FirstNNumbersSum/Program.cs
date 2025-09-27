namespace _02.FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //start:1
            //end: n
            //condition: add number to sum
            //step: add 1

            int sum = 0;
            for (int number = 1; number <= n; number++)
            {
                sum = sum + number;
                
            }
            Console.WriteLine(sum);
            
        }
    }
}
