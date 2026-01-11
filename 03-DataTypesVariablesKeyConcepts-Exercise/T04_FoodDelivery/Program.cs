// Input

var qtyOfChickenMenus = int.Parse(Console.ReadLine());
var qtyOfFishMenus = int.Parse(Console.ReadLine());
var qtyOfVegetarianMenus = int.Parse(Console.ReadLine());

// prices in BGN

var priceOfChickenMenu = 10.35;
var priceOfFishMenu = 12.40;
var priceOfVegetarianMenu = 8.15;
var priceOfDelivery = 2.50; 

//Calculations

var priceForMenus = (qtyOfChickenMenus * priceOfChickenMenu) 
                    +  (qtyOfFishMenus * priceOfFishMenu)
                    + (qtyOfVegetarianMenus * priceOfVegetarianMenu);

var priceOfDessert = priceForMenus * 0.20;

var totalOrderCost = priceForMenus + priceOfDessert + priceOfDelivery;


// Output

Console.WriteLine(totalOrderCost);
