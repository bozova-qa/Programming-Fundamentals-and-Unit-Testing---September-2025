int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//numbers: [1, 2, 3, 4, 5, 6]

int sumEven = 0;
int sumOdd = 0;

foreach(int number in numbers)
{
    
    //какво повтаряме за всеки един елемент от масива, който се съхранява в променливата number
    if (number % 2 == 0)
    {
        sumEven += number;
    }
    else
    {
        sumOdd += number;
    }
}

Console.WriteLine(sumEven - sumOdd);
