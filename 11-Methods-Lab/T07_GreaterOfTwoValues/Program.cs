var currType = Console.ReadLine();

void GetMax(string type)
{
    var input1 = Console.ReadLine();
    var input2 = Console.ReadLine();

    switch (type)
    {
        case "int":
            var a = int.Parse(input1);
            var b = int.Parse(input2);
            Console.WriteLine(Math.Max(a, b));
            break;

        case "char":
            var c1 = char.Parse(input1);
            var c2 = char.Parse(input2);
            Console.WriteLine((char)Math.Max(c1, c2));
            break;

        case "string":
            if (input1.CompareTo(input2) >= 0)
            {
                Console.WriteLine(input1);
            }
            else
            {
                Console.WriteLine(input2);
            }
            break;
    }
}

GetMax(currType);
