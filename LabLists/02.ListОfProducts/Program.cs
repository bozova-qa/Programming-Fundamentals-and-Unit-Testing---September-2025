int countProducts = int.Parse(Console.ReadLine());
List<string> products = new List<string>(); //списък, в който ще съхраняваме въведените продукти

for (int product = 1; product <= countProducts; product++)
{
    string productName = Console.ReadLine();
    products.Add(productName);
}

// products = {"potatoes", "Tomatoes", "Onions", "Apples"}

products.Sort();

//products = {"Apples", "Onions", "potatoes", "Tomatoes"}

int number = 1;
foreach (string product in products)
{
    Console.WriteLine(number + "." + product);
    number++;
}
