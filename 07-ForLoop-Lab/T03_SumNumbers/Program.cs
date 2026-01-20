var n = int.Parse(Console.ReadLine());

var totalSum = 0.0;

for (int i =  1; i <= n; i++)
{
    var number = double.Parse(Console.ReadLine());
    totalSum += number;

}

Console.WriteLine(totalSum);
