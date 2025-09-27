namespace _04.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int startNumber = 7;startNumber <= endNumber;startNumber += 10)
            {
                Console.WriteLine(startNumber);
            }
        }
    }
}
