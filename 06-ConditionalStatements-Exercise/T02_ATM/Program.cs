var balance = int.Parse(Console.ReadLine());
var withdrawal = int.Parse(Console.ReadLine());
var limit = int.Parse(Console.ReadLine());

if (withdrawal <= balance && withdrawal <= limit)
{
    balance -= withdrawal;
    Console.WriteLine("The withdraw was successful.");
}
else if (withdrawal > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else 
{
    Console.WriteLine("Insufficient availability.");
}
