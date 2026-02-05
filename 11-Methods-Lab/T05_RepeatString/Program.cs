var text = Console.ReadLine();
var number = int.Parse(Console.ReadLine());


static string RepeatString(string str, int count)
{
    var result = "";
    
    for (var i = 0; i < count; i++)
    {
        result += str;
    }
    return result;
}

Console.WriteLine(RepeatString(text, number));
