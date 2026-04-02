namespace LibraryBookManagementSystem
{
    class Program
    {
        static void Main(string[]  args)
        {
            while (true)
            {
                Console.WriteLine("\n===== MAIN MENU =====");
                Console.WriteLine("1. Admin Menu");
                Console.WriteLine("2. User Menu");
                Console.WriteLine("3. Exit");

                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AdminMenu();
                        break;

                    case "2":
                        UserMenu();
                        break;

                    case "3":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        // ================= ADMIN MENU =================
        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== ADMIN MENU ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Find Book by ISBN");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Count Available Books");
                Console.WriteLine("6. Back to Main Menu");

                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        LibraryService.AddBook(title, author);
                        break;

                    case "2":
                        LibraryService.ViewAllBooks();
                        break;
                    
                    case "3":
                        Console.Write("Enter ISBN: ");
                        string findIsbn = Console.ReadLine();

                        var book = LibraryService.FindBookByISBN(findIsbn);

                        if (book != null)
                            book.Display();
                        else
                            Console.WriteLine("Book not found.");
                        break;

                    case "4":
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();

                        LibraryService.DeleteBook(isbn);
                        break;
                    
                    case "5":
                        LibraryService.CountAvailableBooks();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        // ================= USER MENU =================
        static void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== USER MENU ===");
                Console.WriteLine("1. View Available Books");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Find Book by ISBN");
                Console.WriteLine("5. Back to Main Menu");

                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        LibraryService.ViewAvailableBooks();
                        break;

                    case "2":
                        Console.Write("Enter ISBN: ");
                        string borrowIsbn = Console.ReadLine();

                        LibraryService.BorrowBook(borrowIsbn);
                        break;

                    case "3":
                        Console.Write("Enter ISBN: ");
                        string returnIsbn = Console.ReadLine();

                        LibraryService.ReturnBook(returnIsbn);
                        break;

                    case "4":
                        Console.Write("Enter ISBN: ");
                        string findIsbn = Console.ReadLine();

                        var book = LibraryService.FindBookByISBN(findIsbn);

                        if (book != null)
                            book.Display();
                        else
                            Console.WriteLine("Book not found.");
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}