var n =  int.Parse(Console.ReadLine());

var partyList = new List<string>();

for (var i =  0; i < n; i++)
{
    var input = Console.ReadLine().Split();
    
    if (partyList.Contains(input[0]) && input[2] == "not")
    {
        partyList.Remove(input[0]);
    }
    else if (!(partyList.Contains(input[0])) && input[2] != "not")
    {
        partyList.Add(input[0]);
    }
    else if (!(partyList.Contains(input[1])) && input[2] == "not")
    {
        Console.WriteLine($"{input[0]} is not in the list!");
    }
    else
    {
        Console.WriteLine($"{input[0]} is already in the list!");
    }
}

Console.WriteLine(string.Join("\n", partyList));
