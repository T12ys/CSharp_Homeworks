// class BankAccount
// {
//     private string BankName;
//     private string BankAccountNumber;
//     private double Balance;
//
//     public BankAccount(string bankName, string bankAccountNumber, double balance)
//     {
//         if (balance < 0)
//             throw new ArgumentException("Initial balance cannot be negative");
//
//         BankName = bankName;
//         BankAccountNumber = bankAccountNumber;
//         Balance = balance;
//     }
//
//     public void WithdrawalOfFunds(double amount)
//     {
//         if (amount <= 0)
//             throw new ArgumentException("Withdrawal amount must be positive");
//
//         if (Balance < amount)
//         {
//             Console.WriteLine("Insufficient funds. Withdrawal canceled.");
//             return;
//         }
//
//         Balance -= amount;
//         Console.WriteLine($"Withdrawal successful. New balance: {Balance}");
//     }
//
//     public void DepositOfFunds(double amount)
//     {
//         if (amount <= 0)
//             throw new ArgumentException("Deposit amount must be positive");
//
//         Balance += amount;
//         Console.WriteLine($"Deposit successful. New balance: {Balance}");
//     }
//
//     public void ShowInfo()
//     {
//         Console.WriteLine($"Bank: {BankName}, Account: {BankAccountNumber}, Balance: {Balance}");
//     }
// }
//
//
// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             BankAccount account = new BankAccount("Kapital Bank", "AZ123456789", 1000);
//             account.ShowInfo();
//
//             account.DepositOfFunds(500);      
//             account.WithdrawalOfFunds(200);  
//
//             account.WithdrawalOfFunds(2000); 
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine($"Input error: {ex.Message}");
//         }
//         catch (InvalidOperationException ex)
//         {
//             Console.WriteLine($"Operation error: {ex.Message}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Unexpected error: {ex.Message}");
//         }
//     }
// }
