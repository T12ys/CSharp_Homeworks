// using System;
//
//
// bool IsLeapYear(int year) =>
//     (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
//
// int GetYearCode(int year)
// {
//     int last_two = year % 100;
//     int century_code = 0;
//     if ((year / 100) % 4 == 0)
//     {
//         century_code = 6;
//     }
//     else if ((year / 100) % 4 == 1)
//     {
//         century_code = 4;
//     }
//     else if ((year / 100) % 4 == 2)
//     {
//         century_code = 2;
//     }
//     else
//     {
//         century_code = 0;
//     }
//     return (century_code + last_two + last_two / 4) % 7;
// }
//
// string GetDayOfWeek(int d, int m, int y)
// {
//     int month_code = 0;
//     if (IsLeapYear(y))
//     {
//         if (m == 1) month_code = 0;
//         else if (m == 2) month_code = 3;
//         else if (m == 3) month_code = 4;
//         else if (m == 4) month_code = 0;
//         else if (m == 5) month_code = 2;
//         else if (m == 6) month_code = 5;
//         else if (m == 7) month_code = 0;
//         else if (m == 8) month_code = 3;
//         else if (m == 9) month_code = 6;
//         else if (m == 10) month_code = 1;
//         else if (m == 11) month_code = 4;
//         else if (m == 12) month_code = 6;
//     }
//     else
//     {
//         if (m == 1) month_code = 1;
//         else if (m == 2) month_code = 4;
//         else if (m == 3) month_code = 4;
//         else if (m == 4) month_code = 0;
//         else if (m == 5) month_code = 2;
//         else if (m == 6) month_code = 5;
//         else if (m == 7) month_code = 0;
//         else if (m == 8) month_code = 3;
//         else if (m == 9) month_code = 6;
//         else if (m == 10) month_code = 1;
//         else if (m == 11) month_code = 4;
//         else if (m == 12) month_code = 6;
//     }
//     
//     int year_code = GetYearCode(y);
//     int day_of_week = (d + month_code + year_code) % 7;
//
//     string[] days = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
//     return days[day_of_week];
// }
//
// string GetMonthName(int month)
// {
//     string[] months = {
//         "January", "February", "March", "April", "May", "June", 
//         "July", "August", "September", "October", "November", "December"
//     };
//     return months[month - 1];
// }
//
// Console.WriteLine("Enter a date (dd.mm.yyyy): ");
// string[] input = Console.ReadLine().Split('.');
//
// int day = Convert.ToInt32(input[0]);
// int month = Convert.ToInt32(input[1]);
// int year = Convert.ToInt32(input[2]);
//
// string day_of_week = GetDayOfWeek(day, month, year);
// string month_name = GetMonthName(month);
// Console.WriteLine($"The day of the week for {day} {month_name} {year} is {day_of_week}");
// //КАК УЗНАТЬ ДЕНЬ НЕДЕЛИ ПО ДАТЕ https://lifehacker.ru/kakoj-den-nedeli/