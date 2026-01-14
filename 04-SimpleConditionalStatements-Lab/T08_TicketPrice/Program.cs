string ticketType = Console.ReadLine();

string result = ticketType switch
{
    "student" => "1.00",
    "regular" => "1.60",
    _         => "Invalid ticket type!"
};

Console.WriteLine(result == "Invalid ticket type!" ? result : $"${result}");
