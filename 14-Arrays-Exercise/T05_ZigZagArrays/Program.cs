var n =  int.Parse(Console.ReadLine());

var firstArray = new int[n];
var secondArray = new int[n];


for (var i =  0; i < n; i++)
{
    var nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
    if (i % 2 == 0)
    {
        firstArray[i] = nums[0];
        secondArray[i] = nums[1];
    }
    else
    {
        firstArray[i] = nums[1];
        secondArray[i] = nums[0];
    }
}

Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));
