var n =  int.Parse(Console.ReadLine());

var vowels = new Dictionary<char, int>
{
    {'a', 1},
    {'e', 2},
    {'i', 3},
    {'o', 4},
    {'u', 5},

};

var vowelSum = 0;

for (var i = 0; i < n; i++)
{
    var letter = char.Parse(Console.ReadLine());

    if (vowels.ContainsKey(letter))
    {
        vowelSum += vowels[letter];
    }
    
    
}

Console.WriteLine(vowelSum);
