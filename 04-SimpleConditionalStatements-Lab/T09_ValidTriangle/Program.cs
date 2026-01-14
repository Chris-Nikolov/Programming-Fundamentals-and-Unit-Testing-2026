int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool isValid = (a + b > c) && (a + c > b) && (b + c > a);

Console.WriteLine(isValid ? "Valid Triangle" : "Invalid Triangle");
