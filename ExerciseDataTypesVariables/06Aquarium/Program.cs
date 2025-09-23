namespace _06Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentageSand = double.Parse(Console.ReadLine());

            int volumeInCm = length * width * height;
            double volumeInL = volumeInCm / 1000.0;
            double waterNeeded = volumeInL - volumeInL * (percentageSand / 100.0);

            Console.WriteLine($"{waterNeeded:F2}");
        }
    }
}
