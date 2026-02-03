var n = int.Parse(Console.ReadLine());

void PrintTriangle(int number)
{
    for (var row = 1; row <= number; row++)
    {
        for (var col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }

        Console.WriteLine();
    }

    for (var row = number - 1; row >= 1; row--)
    {

        for (var col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }

        Console.WriteLine();
    }
}

PrintTriangle(n);
