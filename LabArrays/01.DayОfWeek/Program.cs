int number = int.Parse(Console.ReadLine());

//1 - Monday
//2 - Tuesday
//3 - Wednesday
//4 - Thursday
//5 - Friday
//6 - Saturday
//7 - Sunday

string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

if (number >= 1 && number <= 7)
{
    Console.WriteLine(daysOfWeek[number - 1]);//защото Number и позицията в масива не съвпадат!нум 1->0 позиция
}
else
{
    Console.WriteLine("Invalid day!");
}