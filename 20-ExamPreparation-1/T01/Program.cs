var number = Console.ReadLine();

var result = 0;

foreach (var ch in number)
{
    var digit = int.Parse(ch.ToString());
    
    if (digit % 2 == 0 && digit > 0)
    {
        var factorial = 1;
        
        for (var i = 1; i <= digit; i++)
        {
            factorial *= i;
        }
        result += factorial;
    }
}

Console.WriteLine(result);