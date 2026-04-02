namespace LibraryBookManagementSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; private set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; private set; }

        private static int counter = 10000;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            counter++;
            ISBN = "ISBN/" + counter;

            IsAvailable = true;
            CreatedAt = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Available: {IsAvailable}");
            Console.WriteLine($"Created At: {CreatedAt}");
            Console.WriteLine("----------------------------------");
        }
    }
}