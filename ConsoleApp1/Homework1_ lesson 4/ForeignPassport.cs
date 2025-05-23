// public class ForeignPassport
// {
//     public string PassportNumber;
//     public string FullName;
//     public DateTime IssueDate;
//
//     public ForeignPassport(string passportNumber, string fullName, DateTime issueDate)
//     {
//         if (string.IsNullOrWhiteSpace(passportNumber))
//             throw new Exception("Passport number cannot be empty.");
//
//         if (string.IsNullOrWhiteSpace(fullName))
//             throw new Exception("Full name cannot be empty.");
//
//         if (issueDate > DateTime.Now)
//             throw new Exception("Issue date cannot be in the future.");
//
//         PassportNumber = passportNumber;
//         FullName = fullName;
//         IssueDate = issueDate;
//     }
//
//     public void Show()
//     {
//         Console.WriteLine("Foreign Passport Information:");
//         Console.WriteLine("Passport Number: " + PassportNumber);
//         Console.WriteLine("Full Name: " + FullName);
//         Console.WriteLine("Issue Date: " + IssueDate.ToShortDateString());
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             ForeignPassport passport = new ForeignPassport(
//                 "HU565748423",                       
//                 "Ivan Petrov",                    
//                 new DateTime(2020, 5, 15)          
//             );
//             
//             passport.Show();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error: " + ex.Message);
//         }
//         
//     }
// }