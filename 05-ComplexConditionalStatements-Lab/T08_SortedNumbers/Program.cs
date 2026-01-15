var firstNumber = int.Parse(Console.ReadLine());
var secondNumber = int.Parse(Console.ReadLine());
var thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber && secondNumber > thirdNumber) 
{
    Console.WriteLine("Descending");
}
else  if (firstNumber < secondNumber && secondNumber < thirdNumber)
{
    Console.WriteLine("Ascending");
}
else
{
    Console.WriteLine("Not sorted");
}
