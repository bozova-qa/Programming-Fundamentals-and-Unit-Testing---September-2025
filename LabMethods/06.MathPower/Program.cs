int number = int.Parse(Console.ReadLine());//основа, която ще повдигаме на степен
int power = int.Parse(Console.ReadLine());//степен
PrintPoweredNumber(number, power);

//метод, който взима число и степен и отпечатва числото, повдигнато на степен -->void

static void PrintPoweredNumber(int number,int power)
{
    Console.WriteLine(Math.Pow(number, power));
}