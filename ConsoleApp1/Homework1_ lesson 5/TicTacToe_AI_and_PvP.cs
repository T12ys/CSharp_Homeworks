// namespace TicTacToeGame
// {
//     class Program
//     {
//         static void Main()
//         {
//             string[,] board = new string[3, 3];
//             InitializeBoard(board);
//
//             Console.WriteLine("Добро пожаловать в игру Крестики-Нолики!");
//             Console.WriteLine("Выберите режим игры:");
//             Console.WriteLine("1 — Играть против бота");
//             Console.WriteLine("2 — Играть против другого игрока");
//
//             int mode;
//             while (true)
//             {
//                 Console.Write("Ваш выбор (1 или 2): ");
//                 if (int.TryParse(Console.ReadLine(), out mode) && (mode == 1 || mode == 2))
//                     break;
//                 Console.WriteLine("Неверный выбор. Попробуйте снова.");
//             }
//
//             bool isPlayerTurn = DecideFirstTurn();
//
//             string first;
//             if (isPlayerTurn)
//             {
//                 if (mode == 1)
//                     first = "Вы ходите первым!";
//                 else
//                     first = "Игрок 1 ходит первым!";
//             }
//             else
//             {
//                 if (mode == 1)
//                     first = "Бот ходит первым!";
//                 else
//                     first = "Игрок 2 ходит первым!";
//             }
//             Console.WriteLine(first);
//             Console.ReadKey();
//
//             
//             
//             int moves = 0;
//             while (true)
//             {
//                 Console.Clear();
//                 PrintBoard(board);
//
//                 if (mode == 1) // Игра с ботом
//                 {
//                     if (isPlayerTurn)
//                     {
//                         Console.Write("\nВаш ход. Введите позицию (1–9): ");
//                         int position = GetValidPosition(board);
//                         MarkPosition(board, position, " X ");
//                     }
//                     else
//                     {
//                         Console.WriteLine("\nХод бота...");
//                         Console.ReadKey();
//                         BotMove(board);
//                     }
//                 }
//                 else // Игра между двумя игроками
//                 {
//                     Console.Write($"\nХод {(isPlayerTurn ? "Игрока 1 (X)" : "Игрока 2 (O)")}. Введите позицию (1–9): ");
//                     int position = GetValidPosition(board);
//                     MarkPosition(board, position, isPlayerTurn ? " X " : " O ");
//                 }
//
//                 moves++;
//
//                 string currentSymbol;
//                 if ((mode == 1 && !isPlayerTurn) || (mode == 2 && !isPlayerTurn))
//                     currentSymbol = " O ";
//                 else
//                     currentSymbol = " X ";
//
//                 if (CheckWin(board, currentSymbol))
//                 {
//                     Console.Clear();
//                     PrintBoard(board);
//
//                     if (mode == 1)
//                     {
//                         if (isPlayerTurn)
//                             Console.WriteLine("\nВы победили!");
//                         else
//                             Console.WriteLine("\nБот победил!");
//                     }
//                     else
//                     {
//                         if (isPlayerTurn)
//                             Console.WriteLine("\nПобедил Игрок 1!");
//                         else
//                             Console.WriteLine("\nПобедил Игрок 2!");
//                     }
//
//                     break;
//                 }
//
//                 if (moves == 9)
//                 {
//                     Console.Clear();
//                     PrintBoard(board);
//                     Console.WriteLine("\nНичья!");
//                     break;
//                 }
//
//                 isPlayerTurn = !isPlayerTurn; // Меняем очередь
//             }
//         }
//
//         static void InitializeBoard(string[,] board)
//         {
//             for (int i = 0; i < 3; i++)
//                 for (int j = 0; j < 3; j++)
//                     board[i, j] = " - ";
//         }
//
//         static void PrintBoard(string[,] board)
//         {
//             Console.WriteLine();
//             for (int i = 0; i < 3; i++)
//             {
//                 for (int j = 0; j < 3; j++)
//                     Console.Write(board[i, j]);
//                 Console.WriteLine();
//             }
//         }
//
//         static bool DecideFirstTurn()
//         {
//             Random random = new Random();
//             return random.Next(2) == 0; 
//         }
//
//         static void MarkPosition(string[,] board, int position, string mark)
//         {
//             int row = (position - 1) / 3;
//             int col = (position - 1) % 3;
//             board[row, col] = mark;
//         }
//
//         static bool IsCellTaken(string[,] board, int position)
//         {
//             int row = (position - 1) / 3;
//             int col = (position - 1) % 3;
//             return board[row, col] == " X " || board[row, col] == " O ";
//         }
//
//         static bool CheckWin(string[,] board, string symbol)
//         {
//             for (int i = 0; i < 3; i++)
//             {
//                 if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
//                     return true;
//                 if (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol)
//                     return true;
//             }
//
//             if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
//                 return true;
//             if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
//                 return true;
//
//             return false;
//         }
//
//         static void BotMove(string[,] board)
//         {
//             Random random = new Random();
//             int position;
//
//             while (true)
//             {
//                 position = random.Next(1, 10);
//                 if (!IsCellTaken(board, position))
//                     break;
//             }
//
//             MarkPosition(board, position, " O ");
//         }
//
//         static int GetValidPosition(string[,] board)
//         {
//             int position;
//             while (true)
//             {
//                 if (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > 9)
//                 {
//                     Console.Write("Ошибка! Введите число от 1 до 9: ");
//                     continue;
//                 }
//
//                 if (IsCellTaken(board, position))
//                 {
//                     Console.Write("Клетка занята. Попробуйте другую: ");
//                     continue;
//                 }
//
//                 return position;
//             }
//         }
//     }
// }
