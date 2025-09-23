namespace _04.GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine("Greater number: " + numberOne);
            }
            else 
            {
                Console.WriteLine("Greater number: " + numberTwo);
            }
            
        }
    }
}
