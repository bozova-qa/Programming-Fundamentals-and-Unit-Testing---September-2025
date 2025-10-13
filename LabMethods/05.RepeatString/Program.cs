string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
Console.WriteLine(RepeatText(text, count));
//метод, който приема текст и брой и връща текст, в който първон. текст е повторен определен брой пъти;

static string RepeatText (string text, int count)
{
    string newText = "";
    for (int i = 1; i <= count; i++) //повтаряме text определен брой пъти
    {
        newText += text;
    }
    return newText;
}