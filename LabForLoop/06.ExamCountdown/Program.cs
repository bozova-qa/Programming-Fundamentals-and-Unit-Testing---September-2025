namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            for (int day = 1; day <= days; days -= 1)
            {
                Console.WriteLine($"{days} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}
