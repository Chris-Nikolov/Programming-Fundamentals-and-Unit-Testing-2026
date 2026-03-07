var n = int.Parse(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("0");
}
else
{
    var totalCalories = 0;
    
    for (var i = 0; i < n; i++)
    {
        var itemCalories = int.Parse(Console.ReadLine());
        totalCalories += itemCalories;
        Console.WriteLine(totalCalories);
    }
}
