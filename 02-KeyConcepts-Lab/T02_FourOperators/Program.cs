var firstNumber = double.Parse(Console.ReadLine());
var secondNumber = double.Parse(Console.ReadLine());

var numbersAddition = firstNumber + secondNumber;
var numbersSubtraction = firstNumber - secondNumber;
var numbersMultiplication = firstNumber * secondNumber;
var numbersDivision = firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {numbersAddition:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {numbersSubtraction:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {numbersMultiplication:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {numbersDivision:F2}");
