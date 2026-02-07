var number1 = int.Parse(Console.ReadLine());
var number2 = int.Parse(Console.ReadLine());

static int CalculateFactorial(int number)
{
    var factorial = 1;
    for (var i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}

var firstFactorial = CalculateFactorial(number1);
var secondFactorial = CalculateFactorial(number2);

var result = firstFactorial / secondFactorial;

Console.WriteLine(result);
