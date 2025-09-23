using System.ComponentModel.Design;

namespace _10.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string clothing = "";
            string shoes = "";


            if (degrees >= 10 && degrees <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
            }
            else if (degrees >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
                }
            }
            
        }
    }
}
