var product = Console.ReadLine();

var foodProducts = new HashSet<string> 
{
    "curry", 
    "noodles", 
    "sushi", 
    "spaghetti",
    "bread"
};

var drinkProducts = new HashSet<string>
{
    "tea",
    "water",
    "coffee",
    "juice" 
};

Console.WriteLine(foodProducts.Contains(product) 
    ? "food" 
    : (drinkProducts.Contains(product) ? "drink" : "unknown"));
    