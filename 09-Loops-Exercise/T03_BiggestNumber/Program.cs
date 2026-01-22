var n = int.Parse(Console.ReadLine());

var biggestNumber = int.MinValue;

for (var i = 1 ; i <= n; i++)
{
    var currNumber = int.Parse(Console.ReadLine());
    
    if (currNumber > biggestNumber)
    {
        biggestNumber = currNumber;
    }
}

Console.WriteLine(biggestNumber);
