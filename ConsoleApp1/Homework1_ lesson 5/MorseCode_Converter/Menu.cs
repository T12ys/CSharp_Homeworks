// namespace morseCode;
//
// public class Menu
// {
//     public static void UI()
//     {
//         Console.WriteLine("1. Текст в Морзе");
//         Console.WriteLine("2. Морзе в текст");
//         Console.Write("Выберите режим: ");
//         string choice = Console.ReadLine();
//
//         if (choice == "1")
//         {
//             Console.Write("Введите текст: ");
//             string input = Console.ReadLine().ToUpper();
//             
//             Console.WriteLine(TranslationFromTextToMorse.TextToMorse(input));
//         }
//         else if (choice == "2")
//         {
//             Console.Write("Введите Морзе : ");
//             string morseInput = Console.ReadLine();
//             
//             Console.WriteLine(TranslationFromTextToMorse.MorseToText(morseInput));
//         }
//         else
//         {
//             Console.WriteLine("Неверный выбор.");
//         }
//
//         
//     }
//     public static void Main()
//     {
//         Menu Menu = new Menu();
//         Menu.UI();
//     }
// }