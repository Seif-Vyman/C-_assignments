using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04
{
    internal class LibraryEngine
    {
        public static void ProccessBooks(List<Book> bList, BookFunction bookFunction)
        {

            foreach (var item in bList)
            {
                Console.WriteLine(bookFunction(item));
            }
        }
    }
}
