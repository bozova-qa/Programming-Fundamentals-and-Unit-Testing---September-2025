string type = Console.ReadLine();
PrintGreaterValue(type);

static void PrintGreaterValue(string type)
{
    switch(type)
    {
        case "int":
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);
                
            }
            else
            {
                Console.WriteLine(secondNumber);
                
            }
            break;
        case "char":
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            if (firstChar >= secondChar)
            {
                Console.WriteLine(firstChar);
            }
            else
            {
                Console.WriteLine(secondChar);
            }
            break;
        case "string":
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            if (String.Compare(firstStr, secondStr) >= 0)
            {
                Console.WriteLine(firstStr);
            }
            else
            {
                Console.WriteLine(secondStr);
            }
            break;
    }
}
