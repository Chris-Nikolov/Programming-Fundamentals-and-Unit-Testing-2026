var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

while (true)
{
    var input = Console.ReadLine();

    if (input == "end")
    {
        break;
    }

    var commands = input.Split();
    var commandType = commands[0];

    if (commandType == "Add")
    {
        var number = int.Parse(commands[1]);
        numbers.Add(number);
    }
    else if (commandType == "Remove")
    {
        var number = int.Parse(commands[1]);
        numbers.Remove(number);
    }
    else if (commandType == "RemoveAt")
    {
        var index = int.Parse(commands[1]);
        numbers.RemoveAt(index);
    }
    else if (commandType == "Insert")
    {
        var number = int.Parse(commands[1]);
        var index = int.Parse(commands[2]);
        numbers.Insert(index, number);
    }
}

Console.WriteLine(string.Join(" ", numbers));
