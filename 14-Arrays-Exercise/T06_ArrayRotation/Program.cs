var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

var rotations = int.Parse(Console.ReadLine());

while (rotations > 0)
{
    
    var firstElement = arr[0];
    
    for (var i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    
    arr[arr.Length - 1] = firstElement;

    rotations--;
}

Console.WriteLine(string.Join(" ", arr));
