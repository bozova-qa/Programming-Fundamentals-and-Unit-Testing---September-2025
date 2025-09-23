namespace _03Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int thinnerNeeded = int.Parse(Console.ReadLine());
            int hoursOfWork = int.Parse(Console.ReadLine());

            double priceNylonSm = 1.50;
            double pricePaintPerL = 14.50;
            double pricePaintThinnerPerL = 5.00;
            double priceBags = 0.40;

            double totalPriceNylon = (nylonNeeded + 2) * priceNylonSm;
            double totalPricePaint = (paintNeeded + paintNeeded * 0.10) * pricePaintPerL;
            double totalPriceThinner = thinnerNeeded * pricePaintThinnerPerL;

            double totalPriceMaterials = totalPriceNylon + totalPricePaint + totalPriceThinner + priceBags;

            double pricePerHour = totalPriceMaterials * 0.30;
            double totalPriceWork = hoursOfWork * pricePerHour;

            double totalAmount = totalPriceMaterials + totalPriceWork;

            Console.WriteLine(totalAmount);
        }
    }
}
