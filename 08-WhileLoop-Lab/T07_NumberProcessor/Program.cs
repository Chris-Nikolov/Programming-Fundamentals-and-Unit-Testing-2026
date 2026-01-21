var number = int.Parse(Console.ReadLine());

var command = Console.ReadLine();

while (command != "End")
{
    if (command == "Inc")
    {
        number++;
    }
    else if (command == "Dec")
    {
        number--;
    }
    
    command = Console.ReadLine();
}

Console.WriteLine(number);
