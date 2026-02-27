var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var middle =  numbers.Length / 2;

var firstValue = numbers[middle];
var secondValue = numbers[middle - 1];

var result = (firstValue + secondValue) / 2.00;

Console.WriteLine($"{result:F2}");
