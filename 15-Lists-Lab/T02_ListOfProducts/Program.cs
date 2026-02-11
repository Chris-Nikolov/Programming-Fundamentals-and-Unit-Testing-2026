var n =  int.Parse(Console.ReadLine());
var products = new List<string>();

for (var i = 0; i < n; i++)
{
    var product = Console.ReadLine();
    products.Add(product);
}

products.Sort();

for (var i = 1; i <= products.Count(); i++)
{
    Console.WriteLine($"{i}.{products[i-1]}");
}
