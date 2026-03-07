var stockPrices = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
  
var startIndex = int.Parse(Console.ReadLine());
var endIndex = int.Parse(Console.ReadLine());

var counter = 0;
var totalSum = 0.00;

for (var i = startIndex; i <= endIndex; i++)
{
    totalSum += stockPrices[i];
    counter++;
}

var averagePrice = (totalSum) / counter;

Console.WriteLine($"{averagePrice:F2}");
