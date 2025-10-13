int number = 5;

PrintHello(); //извикване на метод/ method invoke


number += 10;
Console.WriteLine(number);

//извикване на метод/ method invoke
PrintNumber(number);

//методи се създават след програмната логика

//метод без параметри 
static void Printhello ()
{
    Console.WriteLine("Hello");
}

//метод, който отпечатва цяло число

static void PrintNumber(int number)
{
    Console.WriteLine(number);
}