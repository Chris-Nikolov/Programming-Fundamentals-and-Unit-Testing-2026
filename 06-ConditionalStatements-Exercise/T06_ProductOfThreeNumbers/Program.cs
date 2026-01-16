var firstNumber = double.Parse(Console.ReadLine());
var secondNumber = double.Parse(Console.ReadLine());
var thirdNumber = double.Parse(Console.ReadLine());


if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
{
    Console.WriteLine("zero");
}
else
{
    var negativeCount = 0;
    
    if (firstNumber < 0) negativeCount++;
    if (secondNumber < 0) negativeCount++;
    if (thirdNumber < 0) negativeCount++;
    
    if (negativeCount % 2 != 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("positive");
    }
}
