var n = int.Parse(Console.ReadLine());

double count2 = 0;
double count3 = 0;
double count4 = 0;

for (int i = 0; i < n; i++)
{
    var currNumber = int.Parse(Console.ReadLine());
    
    if (currNumber % 2 == 0)
    {
        count2++;
    }
    
    if (currNumber % 3 == 0)
    {
        count3++;
    }
    
    if (currNumber % 4 == 0)
    {
        count4++;
    }
}

var percent2 = (count2 / n) * 100;
var percent3 = (count3 / n) * 100;
var percent4 = (count4 / n) * 100;

Console.WriteLine($"{percent2:F2}%");
Console.WriteLine($"{percent3:F2}%");
Console.WriteLine($"{percent4:F2}%");
