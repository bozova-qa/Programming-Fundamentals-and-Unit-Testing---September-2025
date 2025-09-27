namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            //countNumbers -> number of given numbers
            //start: first number (1)
            //end: last (countNumbers)
            //condition: read double number and sum it
            //step: +1

            double sum = 0;
            for (int count = 1; count <= countNumbers; count++)
            {
                //count - съхранява номера на числото
                double value = double.Parse(Console.ReadLine());
                sum += value; // sum = sum + value;
            }
            Console.WriteLine(sum);
            
        }
    }
}
