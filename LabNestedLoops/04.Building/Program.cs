namespace _04.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int estates = int.Parse(Console.ReadLine());

            for (int floor = floors; floor >= 1; floor--) //етажите намаляват, напр. от 6 до 1;
            {
                //какво искаме да повтаряме за всеки етаж
                for (int estate = 0; estate < estates; estate++)// преминаваме през всяко помещение от 0 до естатес;
                {
                    // отпечатваме неговата табела {type}{floor}{number}
                    if (floor == floors) // ако е последен етаж
                    {
                        Console.Write($"L{floor}{estate} ");
                    }
                    else if (floor % 2 == 0) // дали е четен етаж
                    {
                        Console.Write($"O{floor}{estate} ");
                    }
                    else
                    {
                        //нечетен етаж
                        Console.Write($"A{floor}{estate} ");
                    }
                }
                Console.WriteLine();//сваляме курсора на нов ред;
            }
        }
    }
}
