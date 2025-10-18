int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rotationsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < rotationsCount; i++)
{
    int firstElement = numbers[0];
    for (int j = 1; j < numbers.Length; j++)
    {
        numbers[j - 1] = numbers[j];//всеки елемент минава наляво
    }
    numbers[numbers.Length - 1] = firstElement;//посл. елемент се повтаря два пъти и го приравняваме на първия
}

Console.WriteLine(string.Join(" ", numbers));