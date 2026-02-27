var n = int.Parse(Console.ReadLine());
var magicNumbers = new List<int>();

for (var i = 0; i <= n; i++)
{
    var digits = i.ToString();
    var sumOfDigits = 0;
    var allDigitsArePrime = true;

    foreach (var digit in digits)
    {
        var value = int.Parse(digit.ToString());

        if (value < 2)
        {
            allDigitsArePrime = false;
            break;
        }
        
        var isCurrPrime = true;
        for (var j = 2; j < value; j++)
        {
            if (value % j == 0)
            {
               isCurrPrime = false;
               break;
            }
        }

        if (!isCurrPrime)
        {
            allDigitsArePrime = false;
            break;
        }
        sumOfDigits += value;
    }
    if (allDigitsArePrime && sumOfDigits % 2 == 0)
    {
        magicNumbers.Add(i);
    }
}

if (magicNumbers.Count > 0)
{
    Console.WriteLine(string.Join(" ", magicNumbers));
}
else
{
    Console.WriteLine("no");
}

/*Simplified solution:*/

// var n = int.Parse(Console.ReadLine());
// var magicNumbers = new List<int>();
//
// for (var i = 1; i <= n; i++)
// {
//     var digits = i.ToString();
//     var sumOfDigits = 0;
//     var allDigitsArePrime = true;
//
//     foreach (var digit in digits)
//     {
//         var value = int.Parse(digit.ToString());
//         
//         if (value == 2 || value == 3 || value == 5 || value == 7)
//         {
//             sumOfDigits += value;
//         }
//         else
//         {
//             allDigitsArePrime = false; 
//             break;
//         }
//     }
//     
//     if (allDigitsArePrime && sumOfDigits % 2 == 0)
//     {
//         magicNumbers.Add(i);
//     }
// }
//
// if (magicNumbers.Count > 0)
// {
//     Console.WriteLine(string.Join(" ", magicNumbers));
// }
// else
// {
//     Console.WriteLine("no");
// }