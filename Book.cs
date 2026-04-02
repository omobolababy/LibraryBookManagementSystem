public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; private set; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        ISBN = GenerateISBN();
        IsAvailable = true;
    }

    static int counter = 10000;

    string GenerateISBN()
    {
        counter++;
        return "ISBN/" + counter;
    }

    public void Display()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine($"\nTitle: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Available: {(IsAvailable)}");
        Console.WriteLine($"Created at: {DateTime.Now}");
        Console.WriteLine("-------------------------");
    }
}