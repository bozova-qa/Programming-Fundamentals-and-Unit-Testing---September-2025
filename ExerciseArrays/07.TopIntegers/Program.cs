int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


// 1 for loop за текущото число, 1 за следващото;

for(int i  = 0; i < numbers.Length; i++)
{
    int currentElement = numbers[i];

    bool isBigger = true; //приемаме, че текущото число е по-голямо от всички надясно

    for (int j = i + 1; j < numbers.Length; j++) //проверява от десния елемент до края на масива
    {
        int nextRightElement = numbers[j];

        if (currentElement <= nextRightElement)
        {
            isBigger = false;//не е по-голямо от всички надясно
            break;
        }
        
    }

    if(isBigger)
    {
        Console.Write(currentElement + " ");
    }
}
