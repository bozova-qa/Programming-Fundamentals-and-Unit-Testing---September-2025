namespace _02.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int power = 0; power <= n; power += 2)
            {
                Console.WriteLine(Math.Pow(2,power));
            }
        }// or:
        //int n = int.Parse(Console.ReadLine());
        //int currentNum = 1; //задаваме текущо число 2^0
        //    for (int i = 0; i <= n; i += 2) // задаваме стъпка 2
        //   {
        //       Console.WriteLine(currentNum); // отпечатваме текущо число и го увеличаваме 4 пъти
        //       currentNum = currentNum* 2 * 2;
    }
}
