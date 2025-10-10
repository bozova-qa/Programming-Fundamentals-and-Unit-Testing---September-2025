namespace _01.NumbersFromNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n >= 1) // for (int i = n; n >= 1; i--)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}
