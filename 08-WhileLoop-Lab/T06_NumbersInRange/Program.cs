while (true)
{
    var number = int.Parse(Console.ReadLine());

    if (number < 1 || number > 100)
    {
        continue;
    }
    
    Console.WriteLine($"{number}");
    break;
    
}
