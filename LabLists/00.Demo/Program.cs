//1. Създаваме празен списък:

List<int> numbersList = new List<int>();
List<string> names = new List<string>();

//2. Създаваме списък с предварително зададени елементи

List<string> namesNew = new() { "Peter", "Ana", "Maria" };

//3. Размер на списъка - броя на елементите в него;
names.Count();
Console.WriteLine(names.Count);//можем да отпечатаме броя
int count = names.Count; //можем да го съхраним в променлива

//4. Достъп до елементите на списъка

Console.WriteLine(names[0]);//отпечатва първия елемент в списъка
Console.WriteLine(names[names.Count - 1]);// посл. елемент
string firstName = names[1];//записваме елемент в променлива

//5. Добавяне на елемент в края на списъkа
names.Add("Desi");

//6. Добавяне на елемент на произволно място в списъка (вмъкване)
names.Insert(index, element);
names.Insert(1, "Ivan"); //на 1 позиция добавя Иван;
                                                          //в списъка може да има дублиращи се елементи;
                                                          //позицията, на която вмъкваме, трябва да съществува;

//7. Премахване на елемент от списъка (премахва първото срещане на елемент от списъка)
names.Remove("Ana"); //елементите минават наляво, позициите се променят;
numbers.RemoveAll(number => number == numberToBeRemoved) // премахва всички срещания на числото

//7.1. Премахване на елемент от дадена позиция;
names.RemoveAt(0);

//8. Проверка дали в списъка се съдържа даден елемент
names.Contains("Desi");//връща true или false;
Console.WriteLine(names.Contains("Desi"));//True; можем да отпечатаме
bool isContains = names.Contains("Georgi");// False //можем да съхраним в бул. променлива;

if (names.Contains("Desi"))
{
    Console.WriteLine("Desi is coming!");
}

//9. Обхождане на списък
//1. Начин - for loop

for (int position = 0; position < names.Count; position++) // или position <= names.Count - 1 посл. позиция
{
    string name = names[position];
    Console.WriteLine(name);
}

//2. начин - foreach loop (ползва се в колекции)
foreach (string name in names)
{
    Console.WriteLine(name);
}

//10. Кога използваме масив, кога списък?
//масив - когато имаме съвкупност от елементи и искаме да ги съхраним някъде, без да извършваме операции с тях, просто да ги достъпим
// Lists - когато с тези елементи ще извършваме операции

//11. Прочитане на списък от конзолата

//"45 23 56 78 77".Split() -->  -> става списък от стринг;
//"45", "23", "56", "78", "77".Select(int.Parse)--> преобразуваме в цели числа

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<double> grades = Console.ReadLine().Split().Select(double.Parse).ToList();


//"Tokyo, Sofia, Helsinki"; 
//["Tokyo", "Sofia", "Helsinki"]
//{"Tokyo", "Sofia", "Helsinki" }
List<string> cities = Console.ReadLine().Split(" ,").ToList();

//12. Премахване на всички елементи в списъка
names.Clear();

//13. Сортиране на списък

//нарастващ ред (ascending order)

List<int> nums = new() { 4, 5, 12, 1, -5, 76, 34 };
nums.Sort();//подрежда в нарастващ ред
//nums = {-5, 1, 4, 5, 12, 34, 76 }

//намаляващ ред (descending order)
List<int> numsList = new() { 4, 5, 12, 1, -5, 76, 34 };
nums.Sort();//подрежда в нарастващ ред
//numsList = {-5, 1, 4, 5, 12, 34, 76 }
numsList.Reverse(); //обръща списъка наобратно
//numsList = { 76, 34, 12, 5, 4, 1, -5}