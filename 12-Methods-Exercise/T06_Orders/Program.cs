var product = Console.ReadLine();
var qty = int.Parse(Console.ReadLine());

static void CalculateTotalPrice(string product, int quantity)
{
    var pricePerItem = 0.00;
    
    switch (product)
    {
        case "coffee":
            pricePerItem = 1.50;
            break;
        case "water":
            pricePerItem = 1.00;
            break;
        case "coke":
            pricePerItem = 1.40;
            break;
        case "snacks":
            pricePerItem = 2.00;
            break;
    }
    
    var total = pricePerItem * quantity;
    Console.WriteLine($"{total:f2}");
}

CalculateTotalPrice(product, qty);
