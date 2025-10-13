static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++) //този цикъл печата един ред
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void PrintTriangle(int num)
{
    for (int currentLine = 1; currentLine <= num; currentLine++)//пишем следващ метод да принтира триъгълник
    {
        PrintLine(1, currentLine);// печата по един ред, докато currentLine стане равно на number;
    }
    for (int currentLine = num - 1; currentLine >= 1; currentLine--)//пишем метод линиите да намаляват
    {
        PrintLine(1, currentLine);
    }
}


int number = int.Parse(Console.ReadLine());

PrintTriangle(number);