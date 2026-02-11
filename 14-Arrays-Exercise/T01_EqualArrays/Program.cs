var firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var areIdentical = true;


for (var i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] != secondArray[i])
    {
            areIdentical = false;
            break;
    }
}


if (areIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}
