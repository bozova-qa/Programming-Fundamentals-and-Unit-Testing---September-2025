static void PrintNumberSign(int number)
{
    if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    else if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else
    {
        Console.WriteLine($"The number {number} is negative.");
    }

}

int number = int.Parse(Console.ReadLine());

PrintNumberSign(number);

//int number2 = int.Parse(Console.ReadLine()); --> няма да ни се налага да пишем горния код, ако има следващо число
//PrintNumberSign(number2);
