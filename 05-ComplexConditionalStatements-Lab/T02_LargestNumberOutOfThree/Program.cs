var firstNumber = int.Parse(Console.ReadLine());
var secondNumber = int.Parse(Console.ReadLine());
var thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"{Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber))}");
