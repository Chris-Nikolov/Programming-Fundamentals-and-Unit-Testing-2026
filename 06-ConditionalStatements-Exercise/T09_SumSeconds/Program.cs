var time1 = int.Parse(Console.ReadLine());
var time2 = int.Parse(Console.ReadLine());
var time3 = int.Parse(Console.ReadLine());

var totalTime = time1 + time2 + time3;

var minutes = totalTime / 60;
var seconds = totalTime % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");
