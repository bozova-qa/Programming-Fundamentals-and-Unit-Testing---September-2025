namespace _02.LargestNumberOutOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            if (numOne > numTwo)
            {
                if (numOne > numThree)
                    Console.WriteLine(numOne);
                else
                    Console.WriteLine(numThree);
            }
            else
            {
                if (numTwo > numThree)
                    Console.WriteLine(numTwo);

                else
                    Console.WriteLine(numThree);
            }
        }
    }
}
