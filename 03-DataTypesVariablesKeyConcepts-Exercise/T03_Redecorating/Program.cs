// Input

var amountOfNylons = int.Parse(Console.ReadLine()) + 2;
var amountOfPaint = int.Parse(Console.ReadLine()) * 1.1;
var qtyOfThinner = int.Parse(Console.ReadLine());
var hoursToFinish = int.Parse(Console.ReadLine());

// prices in BGN

var nylonPerSquareMeter = 1.50;
var paintPerLiter = 14.50;
var thinnerPerLiter = 5.00;
var bags = 0.40;

//Calculations

var materialsCost = (amountOfNylons * nylonPerSquareMeter) 
                    + (amountOfPaint * paintPerLiter) 
                    + (qtyOfThinner * thinnerPerLiter) 
                    + bags;

var workPerHourCost = materialsCost * 0.30;

var overallWorkCost = workPerHourCost * hoursToFinish;

var totalCost = materialsCost + overallWorkCost;

// Output

Console.WriteLine(totalCost);
