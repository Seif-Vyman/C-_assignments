
namespace Ass04
{
    public delegate string BookFunction(Book book);
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] authors01 = { "seif", "ammar" };
            string[] authors02 = { "amr", "azzam" };
            string[] authors03 = { "wael", "khattab" };
            string[] authors04 = { "momya", "shihata" };

            Book book01 = new Book("5nn", "Life", authors01,new DateTime(2004,11,09),100);
            Book book02 = new Book("6nn", "Sky", authors02, new DateTime(2005,12,10), 200);
            Book book03 = new Book("7nn", "Ground", authors03, new DateTime(2006,01,11), 300);
            Book book04 = new Book("8nn", "Death", authors04, new DateTime(2007,02,12), 400);
            List<Book> books = new List<Book> {book01,book02,book03,book04 };
            BookFunction bf;
            bf = BookFunctions.GetTitle;
            LibraryEngine.ProccessBooks(books, bf);
            Console.WriteLine("=============================");
            bf = BookFunctions.GetAuthors;
            LibraryEngine.ProccessBooks(books,bf);
            Console.WriteLine("=============================");
            bf = BookFunctions.GetPrice;
            LibraryEngine.ProccessBooks(books, bf);
            Console.WriteLine("=============================");


            Func<Book, string> func01 = BookFunctions.GetAuthors;
            bf = new BookFunction(func01);
            LibraryEngine.ProccessBooks(books, bf);
            Console.WriteLine("=============================");

            Func<Book, string> func02 = delegate (Book b) { return b.ISBN?? "N/A"; };
            Console.WriteLine(func02(book01));
            Console.WriteLine("=============================");

            Func<Book, string> func03 = (b) => b.PublicationDate.ToString("yyyy-MM-dd");
            Console.WriteLine(func03(book02));




        }
    }
}
