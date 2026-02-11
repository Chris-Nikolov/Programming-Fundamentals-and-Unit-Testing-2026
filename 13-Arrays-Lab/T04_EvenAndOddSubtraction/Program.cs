var arrayOfNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var oddNumbers = 0;
var evenNumbers = 0;

foreach (var number in arrayOfNumbers) 
{
    if (number % 2 == 0) 
    {
        evenNumbers += number;
    } 
    else
    {
        oddNumbers += number;
    }
}

Console.WriteLine(evenNumbers - oddNumbers);
