var wagons = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

var maxCapacityPerWagon = int.Parse(Console.ReadLine());

while (true)
{
    var input = Console.ReadLine();
    if (input == "end")
    {
        break;
    }
    
    var command = input.Split();
    var commandName = command[0];
    
    if (commandName == "Add")
    {
        var commandValue = int.Parse(command[1]);
        
        wagons.Add(commandValue);
        continue;
    }
    
    var value = int.Parse(command[0]);
    
    for (var i =  0; i < wagons.Count; i++)
    {
        if (wagons[i] + value <= maxCapacityPerWagon)
        {
            wagons[i] += value;
            break;
        }
    }
}

Console.WriteLine(string.Join(" ", wagons));
