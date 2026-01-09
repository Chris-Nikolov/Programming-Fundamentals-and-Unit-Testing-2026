var depositedAmount = double.Parse(Console.ReadLine());
var termOfDepositInMonths = int.Parse(Console.ReadLine());
var annualInterestRate = double.Parse(Console.ReadLine());

var totalAmount = depositedAmount + termOfDepositInMonths * (depositedAmount * (annualInterestRate / 100)) / 12;

Console.WriteLine($"{totalAmount:F2}");