var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var n = int.Parse(Console.ReadLine());

var minNumber = int.MaxValue;
var maxNumber = int.MinValue;

for (var i = 0; i < n; i++)
{
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    }
    if (numbers[i] < minNumber)
    {
        minNumber = numbers[i];
    }
}

Console.WriteLine(maxNumber);
Console.WriteLine(minNumber);
