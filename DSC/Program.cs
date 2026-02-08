using DSC;

namespace DSC
{

    public abstract class Book
    {
        public string ISBN { get; }
        public string Title { get; }
        public int PublishedYear { get; }
        public decimal Price { get; protected set; }

        protected Book(string isbn, string title, int year, decimal price)
        {
            ISBN = isbn;
            Title = title;
            PublishedYear = year;
            Price = price;
        }

        public virtual bool IsForSale => true;
    }

    public class PaperBook : Book
    {
        public int Stock { get; private set; }

        public PaperBook(string isbn, string title, int year, decimal price, int stock)
            : base(isbn, title, year, price)
        {
            Stock = stock;
        }

        public void ReduceStock(int quantity)
        {
            if (Stock < quantity)
                throw new Exception("Not enough stock available");

            Stock -= quantity;
        }
    }

    public class EBook : Book
    {
        public string FileType { get; }

        public EBook(string isbn, string title, int year, decimal price, string fileType)
            : base(isbn, title, year, price)
        {
            FileType = fileType;
        }
    }

    public class ShowcaseBook : Book
    {
        public ShowcaseBook(string isbn, string title, int year)
            : base(isbn, title, year, 0)
        {
        }

        public override bool IsForSale => false;
    }

}
public class Inventory
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book GetBook(string isbn)
    {
        return books.FirstOrDefault(b => b.ISBN == isbn);
    }

    public decimal BuyBook(string isbn, int quantity, string email, string address)
    {
        Book book = GetBook(isbn);

        if (book == null)
            throw new Exception("Book not found");

        if (!book.IsForSale)
            throw new Exception("This book is not for sale");

        if (book is PaperBook paperBook)
        {
            paperBook.ReduceStock(quantity);
            ShippingService.Send(address);
        }
        else if (book is EBook)
        {
            MailService.Send(email);
        }

        return book.Price * quantity;
    }

    public List<Book> RemoveOutdatedBooks(int maxYears)
    {
        int currentYear = DateTime.Now.Year;

        var outdated = books
            .Where(b => currentYear - b.PublishedYear > maxYears)
            .ToList();

        foreach (var book in outdated)
            books.Remove(book);

        return outdated;
    }
}

public static class ShippingService
{
    public static void Send(string address)
    {
        Console.WriteLine($"Shipping paper book to {address}");
    }
}

public static class MailService
{
    public static void Send(string email)
    {
        Console.WriteLine($"Sending ebook to {email}");
    }
}


internal class Program
    {
        static void Main(string[] args)
        {
            Inventory i = new Inventory();
         

            i.AddBook(new PaperBook("111", "C# Basics", 2020, 200, 5));
            i.AddBook(new EBook("222", "OOP Design", 2022, 150, "PDF"));
            i.AddBook(new ShowcaseBook("333", "Coming Soon", 2024));

            decimal d1 = i.BuyBook("111", 2, "test@mail.com", "Cairo");
            Console.WriteLine($"Paid: {d1}");

            decimal d2 = i.BuyBook("222", 1, "test@mail.com", "");
            Console.WriteLine($"Paid: {d2}");

        }
    }

