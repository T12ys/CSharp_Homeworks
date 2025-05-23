// while (true)
// {
//     Console.Clear();
//     Console.WriteLine("Number Base Converter");
//     Console.WriteLine("1. Decimal to Binary");
//     Console.WriteLine("2. Decimal to Octal");
//     Console.WriteLine("3. Decimal to Hexadecimal");
//     Console.WriteLine("4. Binary to Decimal");
//     Console.WriteLine("5. Octal to Decimal");
//     Console.WriteLine("6. Hexadecimal to Decimal");
//     Console.WriteLine("0. Exit");
//     Console.Write("Select an option: ");
//
//     string choice = Console.ReadLine();
//
//     if (choice == "0")
//         break;
//
//     try
//     {
//         switch (choice)
//         {
//             case "1":
//                 ConvertFromDecimal(2);
//                 break;
//             case "2":
//                 ConvertFromDecimal(8);
//                 break;
//             case "3":
//                 ConvertFromDecimal(16);
//                 break;
//             case "4":
//                 ConvertToDecimal(2);
//                 break;
//             case "5":
//                 ConvertToDecimal(8);
//                 break;
//             case "6":
//                 ConvertToDecimal(16);
//                 break;
//             default:
//                 Console.WriteLine("Invalid option.");
//                 break;
//         }
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Error: {ex.Message}");
//     }
//
//     Console.WriteLine("\nPress any key to continue...");
//     Console.ReadKey();
// }
// void ConvertFromDecimal(int toBase)
// {
//     Console.Write("Enter a number in decimal: ");
//     string input = Console.ReadLine();
//
//     if (int.TryParse(input, out int number))
//     {
//         string result = Convert.ToString(number, toBase);
//         Console.WriteLine($"Result: {result.ToUpper()}");
//     }
//     else
//     {
//         Console.WriteLine("Error: Please enter a valid integer.");
//     }
// }
//
// void ConvertToDecimal(int fromBase)
// {
//     Console.Write($"Enter a number in base {fromBase}: ");
//     string input = Console.ReadLine();
//
//     try
//     {
//         int number = Convert.ToInt32(input, fromBase);
//         Console.WriteLine($"Result: {number}");
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Error: Invalid number format.");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("Error: Number is too large for type int.");
//     }
// }
