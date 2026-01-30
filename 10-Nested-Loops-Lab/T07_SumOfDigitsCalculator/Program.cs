var input = Console.ReadLine();

while (input != "End")
{
    
    var sumOfDigits = 0;
    
    for (var i = 0; i < input.Length; i++)
    {
        sumOfDigits += int.Parse(input[i].ToString());
    }
    Console.WriteLine($"Sum of digits = {sumOfDigits}");
    
    input = Console.ReadLine();
}

Console.WriteLine("Goodbye");
