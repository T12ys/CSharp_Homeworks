// Console.Write("Enter a six-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
//
//
// if (number < 100000 || number > 999999)
// {
//     Console.WriteLine("Error: Please enter a valid six-digit number.");
// }
// else
// {
//     
//     int firstPosition = 0;
//     int secondPosition = 0;
//
//     
//     bool validFirstPosition = false;
//     while (!validFirstPosition)
//     {
//         Console.Write("Enter the position of the first digit to swap (1-6): ");
//         firstPosition = Convert.ToInt32(Console.ReadLine());
//
//         if (firstPosition < 1 || firstPosition > 6)
//         {
//             Console.WriteLine("Error: Please enter a valid position between 1 and 6.");
//         }
//         else
//         {
//             validFirstPosition = true;
//         }
//     }
//
//     
//     bool validSecondPosition = false;
//     while (!validSecondPosition)
//     {
//         Console.Write("Enter the position of the second digit to swap (1-6): ");
//         secondPosition = Convert.ToInt32(Console.ReadLine());
//
//         if (secondPosition < 1 || secondPosition > 6)
//         {
//             Console.WriteLine("Error: Please enter a valid position between 1 and 6.");
//         }
//         else if (secondPosition == firstPosition)
//         {
//             Console.WriteLine("Error: The positions cannot be the same. Please enter different positions.");
//         }
//         else
//         {
//             validSecondPosition = true;
//         }
//     }
//
//     
//     int[] digits = new int[6];
//     for (int i = 0; i < 6; i++)
//     {
//         digits[i] = number % 10; 
//         number /= 10; 
//     }
//
//     
//     (digits[firstPosition - 1], digits[secondPosition - 1]) = (digits[secondPosition - 1], digits[firstPosition - 1]); //Кортежный обмен (a, b) = (b, a)
//
//
//     int result = 0;
//     for (int i = 5; i >= 0; i--)
//     {
//         result = result * 10 + digits[i]; 
//     }
//
//     Console.WriteLine($"The number after swap is: {result}");
// }
