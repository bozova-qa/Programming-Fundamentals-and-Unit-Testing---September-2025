namespace _05BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());

            double priceSneakers = trainingFee - (trainingFee * 0.40);
            double priceUniform = priceSneakers - (priceSneakers * 0.20);
            double priceBall = priceUniform * 0.25;
            double priceAccessories = priceBall * 0.20;

            double totalPrice = trainingFee + priceSneakers + priceUniform + priceBall + priceAccessories;

            Console.WriteLine(totalPrice);
        }
    }
}
