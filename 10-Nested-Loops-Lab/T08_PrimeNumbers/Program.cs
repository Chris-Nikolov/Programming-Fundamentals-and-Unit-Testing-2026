var start = int.Parse(Console.ReadLine());
var stop = int.Parse(Console.ReadLine());

for (var num = start; num <= stop; num++)
{
    if (num < 2) continue;

    var isPrime = true;
    
    for (var i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    
    if (isPrime)
    {
        Console.Write(num + " ");
    }
}
