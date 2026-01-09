var pagesInCurrBook = int.Parse(Console.ReadLine());
var pagesReadPerHour = int.Parse(Console.ReadLine());
var daysToFinish = int.Parse(Console.ReadLine());

var totalHours = pagesInCurrBook / pagesReadPerHour;
var hoursPerDay = totalHours / daysToFinish;

Console.WriteLine(hoursPerDay);