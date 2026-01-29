var n = int.Parse(Console.ReadLine());
var currentNumber = 1;
var elementsOnRow = 1;

while (currentNumber <= n)
{
    for (var j = 0; j < elementsOnRow; j++)
    {
        if (currentNumber <= n)
        {
            Console.Write($"{currentNumber} ");
            currentNumber++;
        }
    }
    Console.WriteLine();
    elementsOnRow++;
}
