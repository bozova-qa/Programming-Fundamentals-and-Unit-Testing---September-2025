namespace DemoNestedLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clock

            for (int hour = 0; hour <= 23; hour++)
            {
                //какво искаме да променяме за всяка една стойност на hour
                for (int minute = 0; minute <= 59;minute++)
                {
                    Console.WriteLine($"{hour}:{minute:D2}");
                }
            }
        }
    }
}
