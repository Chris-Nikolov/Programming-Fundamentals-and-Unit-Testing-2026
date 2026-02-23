var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

var bombProps = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var bombNumber = bombProps[0];
var power = bombProps[1];

while (numbers.Contains(bombNumber))
{
    var bombIndex = numbers.IndexOf(bombNumber);

    var startIndex = Math.Max(0, bombIndex - power);
    
    var endIndex = Math.Min(numbers.Count - 1, bombIndex + power);
    
    var countToRemove = endIndex - startIndex + 1;
    
    numbers.RemoveRange(startIndex, countToRemove);
}

Console.WriteLine(numbers.Sum());
