var letter = char.Parse(Console.ReadLine().ToLower());

var vowels = new HashSet<char> 
{
    'a',
    'e',
    'i',
    'o',
    'u',
};

Console.WriteLine($"{(vowels.Contains(letter) ? "Vowel" : "Consonant")}");
