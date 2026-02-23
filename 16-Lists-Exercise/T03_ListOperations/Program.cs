var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

while (true)
{
    var input = Console.ReadLine();
    
    if (input == "End")
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
        var index = int.Parse(commands[1]);
        
        if (index >= 0 && index < numbers.Count)
        {
            numbers.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (commandType == "Insert")
    {
        var number = int.Parse(commands[1]);
        var index = int.Parse(commands[2]);

        if (index >= 0 && index < numbers.Count)
        {
            numbers.Insert(index, number);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (commandType == "Shift")
    {
        var direction = commands[1];
        var count = int.Parse(commands[2]);

        if (direction == "left")
        {
            for (var i = 0; i < count % numbers.Count; i++)
            {
                var firstNum = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNum);
            }
        }
        else if (direction == "right")
        {
            for (var i = 0; i < count % numbers.Count; i++)
            {
                var lastNum = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNum);
            }
        }
    }    
}

Console.WriteLine(string.Join(" ", numbers));
