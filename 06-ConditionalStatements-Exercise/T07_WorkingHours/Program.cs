var hour = int.Parse(Console.ReadLine());
var day = Console.ReadLine();

var workingDays = new HashSet<string>
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
};

if (workingDays.Contains(day) && hour >= 10 && hour <= 18)
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}
