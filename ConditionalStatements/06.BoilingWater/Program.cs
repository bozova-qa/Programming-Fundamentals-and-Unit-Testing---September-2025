namespace _06.BoilingWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterTemp = int.Parse(Console.ReadLine());
            if (waterTemp > 100)
            {
                Console.WriteLine("The water is boiling");
            }
            else
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}
