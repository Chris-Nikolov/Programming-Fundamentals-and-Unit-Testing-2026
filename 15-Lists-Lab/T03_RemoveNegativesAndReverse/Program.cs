var listOfNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

listOfNumbers.RemoveAll(x => x < 0);
listOfNumbers.Reverse();

if (listOfNumbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine($"{string.Join(" ", listOfNumbers)}");
}
