namespace _07SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packagesPens = int.Parse(Console.ReadLine());
            int packagesMarkers = int.Parse(Console.ReadLine());
            int litersBoardCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pricePens = 5.80;
            double priceMarkers = 7.20;
            double priceBoardCleaner = 1.20;
            double discountCalculation = discount / 100.0;

            double moneyNeeded = packagesPens * pricePens + packagesMarkers * priceMarkers + litersBoardCleaner * priceBoardCleaner;
            double moneyNeededWithDiscount = moneyNeeded - (moneyNeeded * discountCalculation);
            Console.WriteLine(moneyNeededWithDiscount);
        }
    }
}
