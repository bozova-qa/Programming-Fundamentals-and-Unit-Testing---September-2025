int countNumbers = int.Parse(Console.ReadLine());//общ брой числа

int[] numbers = new int[countNumbers];//празен масив за съхранение на числата, с които ще работим

for (int count = 1; count <= countNumbers;count++)
{
    //1. Въвеждаме неговата стойност
    int number = int.Parse(Console.ReadLine());

    //2. Съхранявам в масив
    numbers[count - 1] = number;//[count - 1] позиция
}

//numbers - масив, в който са съхранени всички числа
//да ги отпечатаме в обратен ред

for (int position = numbers.Length - 1; position >= 0; position--)
{
    Console.Write(numbers[position] + " ");
}


