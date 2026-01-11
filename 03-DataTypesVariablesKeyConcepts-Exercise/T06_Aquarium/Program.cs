// Input

var lengthInCm = int.Parse(Console.ReadLine());
var widthInCm = int.Parse(Console.ReadLine());
var heightInCm = int.Parse(Console.ReadLine());
var percentage = double.Parse(Console.ReadLine());

//Calculations

var volumeOfAquarium = lengthInCm * widthInCm * heightInCm;
var volumeInLiters = volumeOfAquarium * 0.001;
var requiredLiters = volumeInLiters * (1 - percentage / 100.00);

// Output

Console.WriteLine($"{requiredLiters:F2}");