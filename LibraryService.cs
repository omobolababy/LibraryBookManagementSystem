namespace LibraryBookManagementSystem
{
    public class LibraryService
    {
        private static List<Book> books = new List<Book>();

        //Add Book 
        public static void AddBook(string title, string author)
        {
            books.Add(new Book(title, author));
            Console.WriteLine("------New Book Alert------");
            Console.WriteLine("Book added successfully.");
            Console.WriteLine("-------------------------");
        }

        //View All Book
        public static void ViewAllBooks()
        {
            if (!books.Any())
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("No books found.");
                Console.WriteLine("-------------------------");
                return;
            }

            foreach (var book in books)
            {
                book.Display();
            }
        }
        
        //Borrow Book

        public static void BorrowBook(string isbn)
        {
            var book = FindBookByISBN(isbn);     // this call the method to find a book with this ISBN, and store the result in the variable book.

            if (book == null)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Book not found.");
                Console.WriteLine("-------------------------");
                return;
            }

            if (!book.IsAvailable)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Book already borrowed.");
                Console.WriteLine("-------------------------");
                return;
            }

            book.IsAvailable = false;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Book borrowed successfully.");
            Console.WriteLine("-------------------------");
        }

        //Return Book
        public static void ReturnBook(string isbn)
        {
            var book = FindBookByISBN(isbn);

            if (book == null)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Book not found.");
                Console.WriteLine("-------------------------");
                return;
            }

            if (book.IsAvailable)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Book is already available.");
                Console.WriteLine("-------------------------");
                return;
            }

            book.IsAvailable = true;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Book returned successfully.");
            Console.WriteLine("-------------------------");
        }

        //Delete Book
        public static void DeleteBook(string isbn)
        {
            var book = FindBookByISBN(isbn);

            if (book == null)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Book not found.");
                Console.WriteLine("-------------------------");
                return;
            }

            books.Remove(book);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Book deleted successfully.");
            Console.WriteLine("-------------------------");
        }

        //Find Book
        public static Book FindBookByISBN(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn); // this go through all books and return the first book whose ISBN matches the one given. If none is found, return null.
        }

        //View Available Books
        public static void ViewAvailableBooks()
        {
            var available = books.Where(b => b.IsAvailable);  // go through all the books and return only the ones that are available

            if (!available.Any())          // Any check directly inside books if any book is available and this checks for if there is NO available book
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("No available books.");
                Console.WriteLine("-------------------------");
                return;
            }

            foreach (var book in available)
            {
                book.Display();
            }
        }
        
        //Count Available Books
        public static void CountAvailableBooks()
        {
            int count = 0;

            foreach (var book in books)
            {
                if (book.IsAvailable)
                {
                    count++;
                }
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Available books: {count}");
            Console.WriteLine("-------------------------");
        }
    }
}