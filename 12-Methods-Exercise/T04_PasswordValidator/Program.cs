var password = Console.ReadLine();

static void PasswordChecker(string password)
{
    if (password.Length < 6 || password.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    var digits = 0;
    var isAlNum = true;
    var isValid = true;

    foreach (var ch in password)
    {
        if (char.IsDigit(ch))
        {
            digits++;
        }
        else
        {
            if (!(char.IsLetter(ch)))
            {
                isAlNum = false;
                isValid = false;
            }
        }
    }

    if (!isAlNum)
    {
        Console.WriteLine("Password must consist only of letters and digits");
        isAlNum = false;
    }
    
    if (digits < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
        isValid = false;
    }
    
    if (isValid)
    {
        Console.WriteLine("Password is valid");
    }
}

PasswordChecker(password);
