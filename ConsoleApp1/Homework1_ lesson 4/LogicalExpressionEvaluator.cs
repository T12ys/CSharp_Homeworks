// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите логическое выражение (например: 12 >= 3): ");
//         string input = Console.ReadLine();
//
//         if (!IsValidLogicalExpression(input))
//         {
//             Console.WriteLine("Неверный формат выражения!");
//             return;
//         }
//
//         string[] operators = { "<=", ">=", "==", "!=", "<", ">" };
//         string foundOperator = null;
//         int opIndex = -1;
//
//         foreach (string op in operators)
//         {
//             opIndex = input.IndexOf(op);
//             if (opIndex != -1)
//             {
//                 foundOperator = op;
//                 break;
//             }
//         }
//
//         if (foundOperator == null)
//         {
//             Console.WriteLine("Оператор не найден.");
//             return;
//         }
//
//         try
//         {
//             
//             string leftStr = input.Substring(0, opIndex).Trim();
//             string rightStr = input.Substring(opIndex + foundOperator.Length).Trim();
//
//             int left = int.Parse(leftStr);
//             int right = int.Parse(rightStr);
//
//             bool result = foundOperator switch
//             {
//                 ">" => left > right,
//                 "<" => left < right,
//                 ">=" => left >= right,
//                 "<=" => left <= right,
//                 "==" => left == right,
//                 "!=" => left != right,
//                 _ => throw new FormatException("Неизвестный оператор.")
//             };
//
//             Console.WriteLine("Результат: " + result);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Ошибка при обработке: " + ex.Message);
//         }
//     }
//
//     static bool IsValidLogicalExpression(string input)
//     {
//         if (string.IsNullOrWhiteSpace(input))
//             return false;
//
//         
//         if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^[\d\s<>=!\-]+$"))
//             return false;
//
//         string[] allowedOperators = { "<=", ">=", "==", "!=", "<", ">" };
//         foreach (string op in allowedOperators)
//         {
//             if (input.Contains(op))
//                 return true;
//         }
//
//         return false;
//     }
// }
