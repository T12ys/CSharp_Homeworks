// Console.WriteLine("Enter the temperature: ");
// if (!(double.TryParse(Console.ReadLine(), out double temperature)))
// {
//     Console.WriteLine("Enter the correct temperature !!!");
//     Environment.Exit(0);
// }
//
// Console.WriteLine("""
//                   Make a choice: 
//                   1)Celsius -> Fahrenheit
//                   2)Fahrenheit -> Celsius
//                   """);
//
// if (!(int.TryParse(Console.ReadLine(), out int choice)))
// {
//     Console.WriteLine("Enter the correct choice !!!");
//     Environment.Exit(0);
// }
//
// if (choice == 1)
// {
//     double Fahrenheit =(temperature * 9 / 5) + 32;
//     Console.WriteLine($"{temperature} degrees Celsius to Fahrenheit: {Fahrenheit}");
// }
// else if (choice == 2)
// {
//     double Celsius = (temperature - 32) * 5 / 9;
//     Console.WriteLine($"{temperature} degrees Fahrenheit to Celsius: {Celsius}");
// }
// else
// {
//     Console.WriteLine("Invalid choice !!!");
// }
//     
