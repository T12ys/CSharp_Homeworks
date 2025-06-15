// namespace morseCode;
//
// class TranslationFromTextToMorse
// {
//     private static Dictionary<char, string> _morseCode = new Dictionary<char, string>()
//     {
//         {'A', ".-"},    {'B', "-..."},  {'C', "-.-."},  {'D', "-.."},
//         {'E', "."},     {'F', "..-."},  {'G', "--."},   {'H', "...."},
//         {'I', ".."},    {'J', ".---"},  {'K', "-.-"},   {'L', ".-.."},
//         {'M', "--"},    {'N', "-."},    {'O', "---"},   {'P', ".--."},
//         {'Q', "--.-"},  {'R', ".-."},   {'S', "..."},   {'T', "-"},
//         {'U', "..-"},   {'V', "...-"},  {'W', ".--"},   {'X', "-..-"},
//         {'Y', "-.--"},  {'Z', "--.."},
//         {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
//         {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."},
//         {'8', "---.."}, {'9', "----."},
//         {' ', "/"}
//     };
//
//     
//     private static Dictionary<string, char> _textCode = new Dictionary<string, char>()
//     {
//         {".-", 'A'},    {"-...", 'B'},  {"-.-.", 'C'},  {"-..", 'D'},
//         {".", 'E'},     {"..-.", 'F'},  {"--.", 'G'},   {"....", 'H'},
//         {"..", 'I'},    {".---", 'J'},  {"-.-", 'K'},   {".-..", 'L'},
//         {"--", 'M'},    {"-.", 'N'},    {"---", 'O'},   {".--.", 'P'},
//         {"--.-", 'Q'},  {".-.", 'R'},   {"...", 'S'},   {"-", 'T'},
//         {"..-", 'U'},   {"...-", 'V'},  {".--", 'W'},   {"-..-", 'X'},
//         {"-.--", 'Y'},  {"--..", 'Z'},
//         {"-----", '0'}, {".----", '1'}, {"..---", '2'}, {"...--", '3'},
//         {"....-", '4'}, {".....", '5'}, {"-....", '6'}, {"--...", '7'},
//         {"---..", '8'}, {"----.", '9'},
//         {"/", ' '}
//     };
//
//     public static string TextToMorse(string input)
//     {
//         input = input.ToUpper();
//         string result = "";
//
//         foreach (char c in input)
//         {
//             if (_morseCode.ContainsKey(c))
//             {
//                 result += _morseCode[c] + " ";
//             }
//         }
//
//         return result.Trim();
//     }
//
//     public static string MorseToText(string input)
//     {
//         string[] parts = input.Split(' ');
//         string result = "";
//
//         foreach (string part in parts)
//         {
//             if (_textCode.ContainsKey(part))
//             {
//                 result += _textCode[part];
//             }
//         }
//
//         return result;
//     }
//     
// }