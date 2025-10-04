using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04
{
    internal static class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title ?? "UnTitled";
        }
        
        public static string GetAuthors(Book book)
        {
            return (book.Authors != null && book.Authors.Length > 0) ? string.Join(", ", book.Authors) : "Unknown";
        }

        public static string GetPrice(Book book)
        {
            return book.Price.ToString();
        }

    }
}
