var number = int.Parse(Console.ReadLine());
var tempNumber = number;
var isSpecial = true;

while (tempNumber > 0)
{
    var digit = tempNumber % 10;
    
    if (number % digit != 0)
    {
        isSpecial = false;
        break;
    }
    
    tempNumber /= 10; 
}

if (isSpecial)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}
