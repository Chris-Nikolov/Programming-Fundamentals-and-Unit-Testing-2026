var num1 = int.Parse(Console.ReadLine());
var num2 = int.Parse(Console.ReadLine());
var num3 = int.Parse(Console.ReadLine());

static void MultiplicationSign(int x, int y, int z)
{
    if (x == 0 || y == 0 || z == 0)
    {
        Console.WriteLine("zero");
    }
    else
    {
        var negativeCount = 0;

        if (x < 0) negativeCount++;
        if (y < 0) negativeCount++;
        if (z < 0) negativeCount++;

        if (negativeCount % 2 != 0)
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("positive");
        }
    }
}

MultiplicationSign(num1, num2, num3);
