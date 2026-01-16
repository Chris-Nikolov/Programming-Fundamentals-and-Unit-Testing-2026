var product = Console.ReadLine();

var fruits = new HashSet<string>
{
    "banana",
    "apple",
    "kiwi",
    "cherry",
    "lemon",
};

var vegetables = new HashSet<string>
{
    "cucumber",
    "pepper",
    "carrot",
};

if (fruits.Contains(product)) Console.WriteLine("fruit");
else if (vegetables.Contains(product)) Console.WriteLine("vegetable");
else Console.WriteLine("unknown");
