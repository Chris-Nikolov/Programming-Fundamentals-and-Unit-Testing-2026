var width = int.Parse(Console.ReadLine());
var length = int.Parse(Console.ReadLine());

static int RectangleArea(int x, int y)
{
    return x * y;
}

Console.WriteLine(RectangleArea(width, length));
