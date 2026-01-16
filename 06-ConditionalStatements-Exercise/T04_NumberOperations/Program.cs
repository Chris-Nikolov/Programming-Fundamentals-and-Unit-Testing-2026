var firstNumber = double.Parse(Console.ReadLine());
var secondNumber = double.Parse(Console.ReadLine());
var mathOperator = char.Parse(Console.ReadLine());

switch (mathOperator)
{
    case     '+':
        Console.WriteLine($"{firstNumber} {mathOperator} {secondNumber} = {firstNumber + secondNumber:F2}");
        break;
    case     '-':
        Console.WriteLine($"{firstNumber} {mathOperator} {secondNumber} = {firstNumber - secondNumber:F2}");
        break;
    case      '*':
        Console.WriteLine($"{firstNumber} {mathOperator} {secondNumber} = {firstNumber * secondNumber:F2}");
        break;
    case       '/':
        Console.WriteLine($"{firstNumber} {mathOperator} {secondNumber} = {firstNumber / secondNumber:F2}");
        break;
};
