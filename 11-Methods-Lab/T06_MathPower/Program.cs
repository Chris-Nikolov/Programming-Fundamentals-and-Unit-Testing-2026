var baseNumber = int.Parse(Console.ReadLine());
var powerNumber = int.Parse(Console.ReadLine());

static  int MathPower(int a, int b)
{
    return (int)Math.Pow(a, b);
}

Console.WriteLine(MathPower(baseNumber, powerNumber));
