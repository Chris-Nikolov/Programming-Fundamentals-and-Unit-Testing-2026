var packagesOfPens = int.Parse(Console.ReadLine());
var packetsOfMarkers =  int.Parse(Console.ReadLine());
var litersOfBoardCleaner = int.Parse(Console.ReadLine());
var discountPercentage = double.Parse(Console.ReadLine());

var priceOfPens = 5.80;
var priceOfMarkers = 7.20;
var pricePerLiterCleaner = 1.20;


var initialCost = (packagesOfPens * priceOfPens) 
                + (packetsOfMarkers * priceOfMarkers) 
                + (litersOfBoardCleaner * pricePerLiterCleaner);

var currDiscount = initialCost * (discountPercentage / 100);

var totalCost = initialCost - currDiscount;

Console.WriteLine(totalCost);