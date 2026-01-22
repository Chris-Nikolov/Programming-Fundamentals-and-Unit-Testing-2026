var stopNumber = int.Parse(Console.ReadLine());
double lastValidNumber = 0;

while (true)
{
    var currNumber = int.Parse(Console.ReadLine());

    if (currNumber == stopNumber)
    {
        lastValidNumber *= 1.20;
        break;
    }
    
    lastValidNumber = currNumber;
}

Console.WriteLine(lastValidNumber);
