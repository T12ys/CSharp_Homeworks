// Console.WriteLine("Enter the number: ");
// if (!(int.TryParse(Console.ReadLine(), out int originalNumber)))
// {
//     Console.WriteLine("Incorrect number: ");
//     Environment.Exit(0);
// }
// int number = originalNumber;
// int sum = 0;
// int digitCount = number.ToString().Length;
//
// while (number > 0)
// {
//     int digit = number % 10;  
//     sum += (int)Math.Pow(digit, digitCount);  
//     number /= 10;  
// }
//
// if (originalNumber == sum)
// {
//     Console.WriteLine($"{originalNumber} is an Armstrong number.");
// }
// else
// {
//     Console.WriteLine($"{originalNumber} is not an Armstrong number.");
// }
