double collectedMoney = 0;
var stopper = false;

while (true)
{
    var destination = Console.ReadLine();
    
    if (destination == "End")
    {
        stopper = true;
    }
    
    if (stopper)
    {
        break;
    }
    
    var price = double.Parse(Console.ReadLine());

    while (true)
    {
        var command = Console.ReadLine();
        
        if (command == "End")
        {
            stopper = true;
            break;
        }
        
        var currMoney = double.Parse(command);
        collectedMoney += currMoney;
        Console.WriteLine($"Collected: {collectedMoney:F2}");
        if (collectedMoney >= price)
        {
            Console.WriteLine($"Going to {destination}!");
            collectedMoney = 0;
            break;
        }
    }
}
