// масив - линейна структура от данни / съвкупност от елементи
//!!! масивът е с фиксирана дължина !!!
//1. Създаване на празен масив от 5 цели числа

using System.ComponentModel.DataAnnotations;

int[] numbers = new int[5]; //когато създаваме масив, трябва да кажем какъв е броят на елементите вътре;
                            //всички елементи първоначално са 0;

//празен масив от 7 дробни числа
double[] prices = new double[7];

//празен масив от 10 текста
string[] names = new string[10];

//2. Размер на масива = дължина на масива --> брой на елементите вътре
Console.WriteLine(numbers.Length); //отпечатва размерът на масива;
int count = prices.Length; // може да се съхранява в променлива;
Console.WriteLine(count);

//3. Добавяне на елементи в масив
numbers[0] = 6; //елементът на нулева позиция става равен на 6;позиция = индекс
numbers[1] = 54;
numbers[2] = 23;
numbers[4] = 89;//посл. елемент в масива
numbers[6] = 24;//няма такава позиция, програмата получава грешка(unhadled exception)

//4. Достъпване на елементи в масив
Console.WriteLine(numbers[1]); //54 - разпечатваме елемент на 1 позиция в масива
int number = numbers[0]; //6 --> можем да го присвоим на променлива
Console.WriteLine(number);

//5. Създаване на масив с предварително зададени елементи
int[] counts = { 3, 4, 5, 6, 1 };
Console.WriteLine(counts);// 5 броя елементи
Console.WriteLine(counts[0]);//3 -> елемент на нулева позиция;
Console.WriteLine(counts[counts.Length - 1]);//1 -> елемент на позиция Length - 1, t.e. 4

//6. Четене на масив от конзолата

int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//получаваме масив от числата, разделени с интервал ["5", "3", "6", "3", "4"] ->
//след това селектираме и преобразуваме в цяло число със Select(int.Parse)

double[] weights = Console.ReadLine()    // "4.5 6.7 8.9"
                    .Split(" ")          //["4,5", "6.7", "8.9"]
                    .Select(double.Parse) //преобразуваме в дробно число [4,5, 6.7, 8.9]
                    .ToArray();
string[] lastNames = Console.ReadLine() // "Ivanov Petrov Mitkov"
                    .Split(" ") // ["Ivanov", "Petrov", "Mitkov"]
                    .ToArray();

//7. Обхождане на масив - преминаване през всеки един от елементите
//начин 1: For loop, който да премине през всички позиции

for (int position = 0; position <= numbers.Length - 1;position++)
{
    Console.WriteLine(numbers[position]);
}

//начин 2: Foreach loop, който да премине през всички елементи
//numbers: [5, 4, 3, 2, 6]

foreach(int num in numbers)
{
    Console.WriteLine(num);
}


//!!! Обхождаме масив с for loop, когато ни интересува на коя позиция е всеки един елемент
//!!! Обхождаме масив с foreach loop, когато ни трябват само елементите, без тяхната позиция

//8. Принтиране на масив
string[] studentNames = { "Desi", "Ivan", "Pesho" };
int[] studentPoints = { 23, 45, 56, 78 };

Console.WriteLine(string.Join('_', studentNames));//Desi_Ivan_Pesho
Console.WriteLine(string.Join('-', studentPoints));// 23-45-56-78
