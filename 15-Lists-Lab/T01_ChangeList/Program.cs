var arrOfNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

var command = Console.ReadLine();

while (command != "end")
{
    var commandArgs = command.Split().ToList();
    var commandName = commandArgs[0];
    
    if (commandName == "Delete")
    {
        arrOfNumbers.RemoveAll(x => x == int.Parse(commandArgs[1]));
    }
    
    else if (commandName == "Insert")
    {
        var value = int.Parse(commandArgs[1]);
        var index = int.Parse(commandArgs[2]);
        if (index >= 0 && index <= arrOfNumbers.Count)
        {
            arrOfNumbers.Insert(index, value);
        }
        
    }
    
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", arrOfNumbers));
