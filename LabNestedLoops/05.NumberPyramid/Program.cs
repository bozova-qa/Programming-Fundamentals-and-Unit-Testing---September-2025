using System.Reflection.Metadata;

namespace _05.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1;//start at 1, will be incremented until number

            for (int row = 1; row <= number; row++)//controls how many rows the pyramid has
            {
                for (int col = 1; col <= row; col++)//prints the current number; runs once for every column in that row;
                {                                     //on 1 row - runs once, 2 row - runs twice...
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                    if (currentNumber > number)// if we printed all the numbers, stop printing more
                    {
                        break;
                    }

                }
                Console.WriteLine();// after finishing the row, move to the next line;
                if (currentNumber > number) //If all numbers are already printed, break out of the outer loop too.
                {
                    break;
                }
            }
        }
    }
}
