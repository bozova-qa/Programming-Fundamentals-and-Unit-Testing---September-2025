int number = int.Parse(Console.ReadLine());

int[] firstArray = new int[number];//празни масиви с дължина 0
int[] secondArray = new int[number];

for (int i = 0; i < number; i++)
{
    int[] rowArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    


    if (i % 2 == 0)
    {
        firstArray[i] = rowArray[0];//пращаме първото число в първия масив на 0 позиция;
        secondArray[i] = rowArray[1]; //пращаме второто число във втория масив на 0 позиция;
    }
    else
    {
        firstArray[i] = rowArray[1];//сега ги пращаме обратно
        secondArray[i] = rowArray[0];
    }
}

Console.WriteLine(string.Join(' ', firstArray));//обединява ги в колекция
Console.WriteLine(string.Join(' ', secondArray));