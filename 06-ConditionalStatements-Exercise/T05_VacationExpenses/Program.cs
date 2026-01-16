var season = Console.ReadLine();
var accomodationType = Console.ReadLine();
var countOfDays = int.Parse(Console.ReadLine());

var price = 0.00;

if (season == "Winter")
{
    if (accomodationType == "Hotel")
    {   
        price += (countOfDays * 40) * 0.90;
    }
    else if (accomodationType == "Camping")
    {
        price += (countOfDays * 10) * 0.90;
    }    
}
else if (season == "Spring")
{
    if (accomodationType == "Hotel")
    {
        price += (countOfDays * 30) * 0.80;
    }
    else if (accomodationType == "Camping")
    {
        price += (countOfDays * 10) * 0.80;
    }
}
else if (season == "Summer")
{
    if (accomodationType == "Hotel")
    {
        price += (countOfDays * 50);
    }
    else if (accomodationType == "Camping")
    {
        price += (countOfDays * 30);
    }    
}
else if (season == "Autumn")
{
    if (accomodationType == "Hotel")
    {
        price += (countOfDays * 20) * 0.70;
    }
    else if (accomodationType == "Camping")
    {
        price += (countOfDays * 15) * 0.70;
    }
}

Console.WriteLine($"{price:F2}");
