int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int controlNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length - 1; i++)//до предпоследния елемент
{
    for (int j = i + 1; j < numbers.Length; j++)//rightElement - до последния елемент
    {
        int sum = numbers[i] + numbers[j];
        if (sum == controlNumber)
        {
            Console.WriteLine(numbers[i] + " " + numbers[j]);
        }
    }
    
}