//Input
int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


//Calculations
while(numbers.Length > 1)
{
    int[] condensedArray = new int[numbers.Length - 1];//масив, в който ще записваме сметнатите числа
                                                        //неговият размер ще е всеки път с едно по-малко от изходния

    for (int position = 0; position < numbers.Length - 1; position++)//спирам на предпоследния елемент
    {
        int sumElements = numbers[position] + numbers[position + 1];//добавяме сумата към празния масив condensedArray
        condensedArray[position] = sumElements;
    }
    numbers = condensedArray;//след 1 преминаване, condensedArray замества Numbers, защото продължаваме да смятаме с новите числа;
}

//Output
Console.WriteLine(numbers[0]);
