var nums = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var controlNum = int.Parse(Console.ReadLine());


for (var i = 0; i < nums.Length; i++)
{
    for (var j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == controlNum)
        {
            if (nums[i] + nums[j] == controlNum)
            {
                Console.WriteLine($"{nums[i]} {nums[j]}");
            }
        }
    }
}
