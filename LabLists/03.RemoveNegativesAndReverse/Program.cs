List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

numbers.RemoveAll(number => number < 0);//премахваме негативните

numbers.Reverse();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(String.Join(" ",numbers));
}