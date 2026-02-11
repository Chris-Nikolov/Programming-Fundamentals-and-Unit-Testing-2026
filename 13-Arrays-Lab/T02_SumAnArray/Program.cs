var arrayONumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Console.WriteLine($"{arrayONumbers.Sum()}");
