// namespace Library.Books
// {
//     public class Book
//     {
//         public string Title;
//         public string Author;
//         public string Genre;
//         public bool IsBorrowed;
//
//         public Book(string title, string author, string genre)
//         {
//             Title = title;
//             Author = author;
//             Genre = genre;
//             IsBorrowed = false;
//         }
//
//         public string GetInfo()
//         {
//             string status;
//             if (IsBorrowed)
//             {
//                 status = "Not Available ";
//             }
//             else
//             {
//                 status = "Available";
//             }
//             return Title + " by " + Author + " [" + Genre + "] - " + status;
//         }
//     }
// }
//
// namespace Library.Members
// {
//     public class Member
//     {
//         public string Name;
//         public int CardNumber;
//
//         public Member(string name, int cardNumber)
//         {
//             Name = name;
//             CardNumber = cardNumber;
//         }
//
//         public string GetInfo()
//         {
//             return Name + " (Card #" + CardNumber + ")";
//         }
//     }
// }
//
// namespace Library.Operations
// {
//     using Library.Books;
//     using Library.Members;
//
//     public class LibrarySystem
//     {
//         private List<Book> books = new ();
//         private List<Member> members = new ();
//
//         public void AddBook(Book book)
//         {
//             books.Add(book);
//         }
//
//         public void AddMember(Member member)
//         {
//             members.Add(member);
//         }
//
//         public void ShowBooks()
//         {
//             Console.WriteLine("\nBooks in Library:");
//             for (int i = 0; i < books.Count; i++)
//             {
//                 Console.WriteLine(books[i].GetInfo());
//             }
//         }
//
//         public void ShowMembers()
//         {
//             Console.WriteLine("\nRegistered Members: ");
//             for (int i = 0; i < members.Count; i++)
//             {
//                 Console.WriteLine(members[i].GetInfo());
//             }
//         }
//
//         public void BorrowBook(string title, int cardNumber)
//         {
//             Book book = null;
//             for (int i = 0; i < books.Count; i++)
//             {
//                 if (books[i].Title == title && books[i].IsBorrowed == false)
//                 {
//                     book = books[i];
//                     break;
//                 }
//             }
//
//             Member member = null;
//             for (int i = 0; i < members.Count; i++)
//             {
//                 if (members[i].CardNumber == cardNumber)
//                 {
//                     member = members[i];
//                     break;
//                 }
//             }
//
//             if (book != null && member != null)
//             {
//                 
//                 book.IsBorrowed = true;
//                 Console.WriteLine(member.Name + " borrowed \"" + book.Title + "\".");
//                 
//             }
//             else
//             {
//                 Console.WriteLine("Book is not available or member not found.");
//             }
//         }
//
//         public void ReturnBook(string title)
//         {
//             
//             Book book = null;
//             for (int i = 0; i < books.Count; i++)
//             {
//                 
//                 if (books[i].Title == title && books[i].IsBorrowed == true)
//                 {
//                     
//                     book = books[i];
//                     break;
//                     
//                 }
//             }
//
//             if (book != null)
//             {
//                 
//                 book.IsBorrowed = false;
//                 Console.WriteLine("\"" + book.Title + "\" has been returned.");
//                 
//             }
//             else
//             {
//                 Console.WriteLine("Book not found or wasn't borrowed.");
//             }
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var library = new Library.Operations.LibrarySystem();
//
//         library.AddBook(new Library.Books.Book("1984", "George Orwell", "Dystopian"));
//         library.AddBook(new Library.Books.Book("The Hobbit", "J.R.R. Tolkien", "Fantasy"));
//         library.AddBook(new Library.Books.Book("C# Basics", "John Smith", "Programming"));
//
//         library.AddMember(new Library.Members.Member("Alice", 101));
//         library.AddMember(new Library.Members.Member("Bob", 102));
//
//         while (true)
//         {
//             Console.WriteLine("\n--- Library Menu ---");
//             Console.WriteLine("1. Show Books");
//             Console.WriteLine("2. Show Members");
//             Console.WriteLine("3. Add Book");
//             Console.WriteLine("4. Add Member");
//             Console.WriteLine("5. Borrow Book");
//             Console.WriteLine("6. Return Book");
//             Console.WriteLine("0. Exit");
//             Console.Write("Choose an option: ");
//             
//             string input = Console.ReadLine();
//
//             if (input == "1")
//             {
//                 library.ShowBooks();
//             }
//             else if (input == "2")
//             {
//                 library.ShowMembers();
//             }
//             else if (input == "3")
//             {
//                 Console.Write("Enter title: ");
//                 string title = Console.ReadLine();
//                 Console.Write("Enter author: ");
//                 string author = Console.ReadLine();
//                 Console.Write("Enter genre: ");
//                 string genre = Console.ReadLine();
//                 library.AddBook(new Library.Books.Book(title, author, genre));
//             }
//             else if (input == "4")
//             {
//                 Console.Write("Enter member name:");
//                 string name = Console.ReadLine();
//                 Console.Write("Enter card number: ");
//                 string cardInput = Console.ReadLine();
//                 int cardNumber;
//                 if (int.TryParse(cardInput, out cardNumber))
//                 {
//                     library.AddMember(new Library.Members.Member(name, cardNumber));
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid card number.");
//                 }
//             }
//             else if (input == "5")
//             {
//                 Console.Write("Enter book title to borrow: ");
//                 string title = Console.ReadLine();
//                 Console.Write("Enter card number: ");
//                 string cardInput = Console.ReadLine();
//                 int cardNumber;
//                 if (int.TryParse(cardInput, out cardNumber))
//                 {
//                     library.BorrowBook(title, cardNumber);
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid card number.");
//                 }
//             }
//             else if (input == "6")
//             {
//                 Console.Write("Enter book title to return: ");
//                 string title = Console.ReadLine();
//                 library.ReturnBook(title);
//             }
//             else if (input == "0")
//             {
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid option.");
//             }
//         }
//     }
// }
