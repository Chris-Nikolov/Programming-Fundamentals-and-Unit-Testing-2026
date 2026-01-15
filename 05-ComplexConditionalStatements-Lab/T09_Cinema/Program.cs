var typeOfMovie = Console.ReadLine();
var countOfRows = int.Parse(Console.ReadLine());
var countOfSeats = int.Parse(Console.ReadLine());

var pricesPerMovieType = new Dictionary<string, double>
{
    { "Premiere", 12.00 },
    { "Normal", 7.50 },
    { "Discount", 5.00 },
};

var totalSeats = countOfRows * countOfSeats;

var totalPrice = pricesPerMovieType[typeOfMovie] * totalSeats;

Console.WriteLine($"{totalPrice:F2}");
