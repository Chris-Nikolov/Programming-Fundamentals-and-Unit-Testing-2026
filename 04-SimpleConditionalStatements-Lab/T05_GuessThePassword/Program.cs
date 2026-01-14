var password = Console.ReadLine();

var secret = "s3cr3t!";

Console.WriteLine($"{(password == secret ? "Welcome" : "Wrong password!")}");
