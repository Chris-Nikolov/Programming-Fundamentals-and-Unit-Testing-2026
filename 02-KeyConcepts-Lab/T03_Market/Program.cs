var pricePerTomato = double.Parse(Console.ReadLine());
var tomatoQuantity = double.Parse(Console.ReadLine());
var pricePerCucumber = double.Parse(Console.ReadLine());
var cucumberQuantity = double.Parse(Console.ReadLine());

var totalCost = (pricePerTomato * tomatoQuantity) + (pricePerCucumber * cucumberQuantity);

Console.WriteLine($"{totalCost:F2}");