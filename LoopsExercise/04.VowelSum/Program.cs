using System.Xml.XPath;

namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            int result = 0;
            
            for (int i = 1; i <= count; i++)
            {
                char vowel = char.Parse(Console.ReadLine());

                switch(vowel)
                {
                    case 'a':
                        result++;
                        break;
                    case 'e':
                        result += 2;
                        break;
                    case 'i':
                        result += 3;
                        break;
                    case 'o':
                        result += 4;
                        break;
                    case 'u':
                        result += 5;
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
