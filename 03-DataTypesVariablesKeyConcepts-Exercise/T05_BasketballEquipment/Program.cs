// Input

var annualTrainingFee = int.Parse(Console.ReadLine());

// prices

var sneakersPrice = (annualTrainingFee * 0.60);
var uniformPrice = sneakersPrice * 0.80;
var ballPrice = uniformPrice * 0.25; 
var accessoriesPrice = ballPrice * 0.20;

var totalCost = annualTrainingFee + sneakersPrice + uniformPrice + ballPrice + accessoriesPrice;

// Output

Console.WriteLine(totalCost);
