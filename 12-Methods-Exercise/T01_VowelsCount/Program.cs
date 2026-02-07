var text = Console.ReadLine().ToLower();

static void VowelsCount(string word)
{
    var vowels = new char [5] { 'a', 'e', 'i', 'o', 'u' };

    int result = 0;

    foreach (var ch in word)
    {
        if (vowels.Contains(ch))
        {
            result += 1;
        }
    }
    
    Console.WriteLine(result);
}

VowelsCount(text);
