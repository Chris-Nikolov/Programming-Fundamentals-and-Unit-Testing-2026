var n = int.Parse(Console.ReadLine());
var arr = new int[n];

for (var i = 0; i < n; i++)
{
    var currNumber = int.Parse(Console.ReadLine());
    arr[i] = currNumber;
}

Console.WriteLine(string.Join(" ", arr.Reverse()));
