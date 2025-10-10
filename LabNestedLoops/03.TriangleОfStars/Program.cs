namespace _03.TriangleОfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int size = int.Parse(Console.ReadLine());

            //без вложен цикъл
            //For loop
            // start: 1
            //end: size
            //repeat: print a row
            //step: +1

            //for (int row = 1; row <= size; row++)
            //{
            //    Console.WriteLine(new String('*', row));//created a string made of 'row' and '*'; повтаря се row-пъти
            //}




            //с вложен цикъл

            int size = int.Parse(Console.ReadLine());
            for (int row = 1; row <= size; row++)
            {
                //повтаряме: отпечатваме * определен брой пъти
                for (int count = 1; count <= row; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();//свали курсора на следващия ред, за да може той да се отпечата отдолу;
            }
        }
    } 
}
