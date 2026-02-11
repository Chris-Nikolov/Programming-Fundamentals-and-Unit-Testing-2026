string[] week = new string[7]
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

var number =  int.Parse(Console.ReadLine());

if (number <= week.Length && number > 0)
{
    Console.WriteLine(week[number - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}
