List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


string command = Console.ReadLine();

while (command != "end")
{
    //1. command = Delete 5 ->commandParts = ["Delete", "5"]
    //2. command = Insert 10 1 -> commandParts = ["Insert", "10", "1"]

    string[] commandParts = command.Split();//създаваме текстов масив от частите на командата
    string commandName = commandParts[0];//достъпваме Insert или Delete
    if (commandName == "Delete")
    {
        int numberToBeRemoved = int.Parse(commandParts[1]);//"5" -> int.Parse -> 5
        numbers.RemoveAll(number => number == numberToBeRemoved);//премахва всички три 5ци
    }
    else if (commandName == "Insert")
    {
        int numberToInsert = int.Parse(commandParts[1]);
        int positionToInsert = int.Parse(commandParts[2]);
        numbers.Insert(positionToInsert, numberToInsert);
    }
        command = Console.ReadLine();//четем следваща команда
}
Console.WriteLine(string.Join(" ", numbers));
