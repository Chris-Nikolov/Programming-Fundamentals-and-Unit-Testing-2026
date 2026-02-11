var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

var topIntegers = new List<int>();

for (var i = 0; i < nums.Length; i++)
{
    var isTop = true;

    for (var j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] <= nums[j])
        {
            isTop = false;
            break;
        }
    }
    
    if (isTop)
    {
        topIntegers.Add(nums[i]);
    }
}

Console.WriteLine(string.Join(" ", topIntegers));
