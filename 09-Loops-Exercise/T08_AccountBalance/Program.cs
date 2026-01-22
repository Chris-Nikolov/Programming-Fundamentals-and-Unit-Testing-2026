double balance = 0;

while (true)
{
    var command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }
    
    var transaction = double.Parse(command);

    if (transaction >= 0)
    {
        balance += transaction;
        Console.WriteLine($"Increase: {transaction:F2}");
    }
    else
    {
        balance += transaction;
        Console.WriteLine($"Decrease: {Math.Abs(transaction):F2}");
    }
}

Console.WriteLine($"Balance: {balance:F2}");
