//създаване на return type method
int number = GetNumber();
Console.WriteLine(GetNumber());

if (GetNumber () == 0)
{

}

static int GetNumber ()
{
    return 3;
}

//void method сравнение
static void PrintNumber ()
{
    Console.WriteLine(3); //ако тук ползваме return, методът бива приключен
}