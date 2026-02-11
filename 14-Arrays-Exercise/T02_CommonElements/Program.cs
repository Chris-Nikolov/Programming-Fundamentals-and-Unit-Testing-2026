var firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var commonElements = new List<int>();

for (var i = 0; i < firstArray.Length; i++)
{
    if (secondArray.Contains(firstArray[i]))
    {
        commonElements.Add(firstArray[i]);
        
    }
}

Console.WriteLine(string.Join(" ", commonElements));
