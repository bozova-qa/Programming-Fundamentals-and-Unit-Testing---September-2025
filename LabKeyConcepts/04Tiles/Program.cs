namespace _04Tiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double W = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double Wt = double.Parse(Console.ReadLine());
            double Ht = double.Parse(Console.ReadLine());

            double bathroomArea = W * H;
            double areaWithSurplus = bathroomArea + bathroomArea * 0.10;
            double tilesArea = Wt * Ht;
            double tilesNeeded = areaWithSurplus / tilesArea;
            double rounded = Math.Round(tilesNeeded, 0);
            Console.WriteLine(rounded);
        }
    }
}
