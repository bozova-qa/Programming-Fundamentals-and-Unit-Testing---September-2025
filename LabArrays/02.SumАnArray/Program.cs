int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//Console.ReadLine()->"5 3 6 3 4".Split(" ")-> ["5", "3", "6", "3", "4"].Select(int.Parse)->[5, 3, 6, 3, 4]

int sum = 0;//сума на всички елементи

// трябва да обходим всички елементи от масива и да ги сумираме

//Начин 1: For Loop, който да премине през всички позиции
for (int position = 0; position <= numbers.Length - 1; position++)
{
    int number = numbers[position];
    sum += number;
}
Console.WriteLine(sum);

//Начин 2: Foreach loop
