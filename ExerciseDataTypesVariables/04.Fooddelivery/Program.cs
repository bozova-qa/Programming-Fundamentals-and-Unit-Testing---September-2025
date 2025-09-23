namespace _04.Fooddelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberChickenMenus = int.Parse(Console.ReadLine());
            int numberFishMenus = int.Parse(Console.ReadLine());
            int numberVegetarianMenus = int.Parse(Console.ReadLine());

            double priceChickenMenu = 10.35;
            double priceFishMenu = 12.40;
            double PriceVegetarianMenu = 8.15;
            double priceDelivery = 2.50;

            double totalPriceWithoutDelivery = numberChickenMenus * priceChickenMenu +
                numberFishMenus * priceFishMenu + numberVegetarianMenus * PriceVegetarianMenu;
            double priceDesert = totalPriceWithoutDelivery * 0.20;
            double totalAmount = totalPriceWithoutDelivery + priceDesert + priceDelivery;
            
            Console.WriteLine(totalAmount);
        }
    }
}
