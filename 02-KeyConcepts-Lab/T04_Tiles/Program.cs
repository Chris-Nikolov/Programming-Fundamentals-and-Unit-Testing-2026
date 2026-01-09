using System.Reflection.Metadata;

var bathroomWidth = double.Parse(Console.ReadLine());
var bathroomHeight = double.Parse(Console.ReadLine());
var tileWidth = double.Parse(Console.ReadLine());
var tileHeight = double.Parse(Console.ReadLine());

var bathroomArea = (bathroomWidth * bathroomHeight);
var tileArea = (tileWidth * tileHeight);
var bonusMaterials = bathroomArea * 0.1;
var totalNeededMaterials = Math.Round((bathroomArea + bonusMaterials) / tileArea);

Console.WriteLine(totalNeededMaterials);
