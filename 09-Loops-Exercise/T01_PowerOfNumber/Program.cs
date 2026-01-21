var number = int.Parse(Console.ReadLine());
var power = int.Parse(Console.ReadLine());

var result = 1;

for (int i = 0; i < power; i++)
{
    result = result * number;
}

Console.WriteLine(result);
