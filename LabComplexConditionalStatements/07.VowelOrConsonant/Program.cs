namespace _07.VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            if (letter == 'A' || letter == 'a' ||
                letter == 'E' || letter == 'e' ||
                letter == 'I' || letter == 'i' ||
                letter == 'O' || letter == 'o' ||
                letter == 'U' || letter == 'u')
                Console.WriteLine("Vowel");
            else if (letter == 'B' || letter == 'b' ||
                     letter == 'C' || letter == 'c' ||
                     letter == 'D' || letter == 'd' ||
                     letter == 'F' || letter == 'f' ||
                     letter == 'G' || letter == 'g' ||
                     letter == 'H' || letter == 'h' ||
                     letter == 'J' || letter == 'j' ||
                     letter == 'K' || letter == 'k' ||
                     letter == 'L' || letter == 'l' ||
                     letter == 'M' || letter == 'm' ||
                     letter == 'N' || letter == 'n' ||
                     letter == 'P' || letter == 'p' ||
                     letter == 'Q' || letter == 'q' ||
                     letter == 'R' || letter == 'r' ||
                     letter == 'S' || letter == 's' ||
                     letter == 'T' || letter == 't' ||
                     letter == 'V' || letter == 'v' ||
                     letter == 'W' || letter == 'w' ||
                     letter == 'X' || letter == 'x' ||
                     letter == 'Y' || letter == 'y' ||
                     letter == 'Z' || letter == 'z')
                Console.WriteLine("Consonant");
        }
    }
}
