var number = Math.Abs(int.Parse(Console.ReadLine()));

static int GetSumOfEvenDigits(int number)
{
    var sum = 0;
    while (number > 0)
    {
        var lastDigit = number % 10;
        if (lastDigit % 2 == 0)
        {
            sum += lastDigit;
        }
        number /= 10;
    }
    return sum;
}

static int GetSumOfOddDigits(int number)
{
    var sum = 0;
    while (number > 0)
    {
        var lastDigit = number % 10;
        if (lastDigit % 2 != 0)
        {
            sum += lastDigit;
        }
        number /= 10;
    }
    return sum;
}

static int GetMultipleOfEvenAndOdds(int number)
{
    var evenSum = GetSumOfEvenDigits(number);
    var oddSum = GetSumOfOddDigits(number);

    return evenSum * oddSum;
}

var result = GetMultipleOfEvenAndOdds(number);
Console.WriteLine(result);
