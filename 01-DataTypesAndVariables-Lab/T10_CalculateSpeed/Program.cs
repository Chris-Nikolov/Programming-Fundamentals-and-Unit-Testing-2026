/*10*/
var speed = Console.ReadLine();
var speedToFloat = float.Parse(speed);
var distance = Console.ReadLine();
var distanceToFloat = float.Parse(distance);
Console.WriteLine($"{speedToFloat /distanceToFloat:f2}");