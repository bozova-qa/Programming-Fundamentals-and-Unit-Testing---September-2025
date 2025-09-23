namespace _04.NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            string operatorMath = Console.ReadLine();

            if (operatorMath == "+") {
                Console.WriteLine($"{numOne + " " + operatorMath + " " + numTwo + " = "}{numOne + numTwo:F2}");
            }
            else if (operatorMath == "-")
            {
                Console.WriteLine($"{numOne + " " + operatorMath + " " + numTwo + " = "}{numOne - numTwo:F2}");
            }
            else if (operatorMath == "*")
            {
                Console.WriteLine($"{numOne + " " + operatorMath + " " + numTwo + " = "}{numOne * numTwo:F2}");
            }
            else if (operatorMath == "/")
            {
                Console.WriteLine($"{numOne + " " + operatorMath + " " + numTwo + " = "}{numOne / numTwo:F2}");
            }

        }
    }
}
