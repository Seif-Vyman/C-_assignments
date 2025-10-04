using LINQ01.Data;
using System.Text.RegularExpressions;
using System.Threading;
using static LINQ01.Data.ListGenerator;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators

            //var result = ProductList.First(P => P.UnitsInStock == 0);

            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(N => N > 5).Skip(1).First();

            //Console.WriteLine(result);

            #endregion

            #region LINQ - Aggregate Operators

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(N => N % 2 == 1).Count();

            //var result = CustomerList.Select(C => new { CustomerName = C.CustomerName, NumberOfOrders = C.Orders.Length});

            //var result = ProductList.Select(P => P.Category).Distinct()
            //                        .Select(C => new { CategoryName = C, NumberOfProducts = ProductList.Count(P => P.Category == C) });


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum(N => N);

            //string text = File.ReadAllText("dictionary_english.txt");

            //string[] words = text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries); 

            //int count = words.Sum(W => W.Length);
            //Console.WriteLine(count);

            //string shortestWord = words.OrderBy(W => W.Length).First();
            //Console.WriteLine(shortestWord);

            //string longestWord = words.OrderByDescending(W => W.Length).First();
            //Console.WriteLine(longestWord);

            //double avg = words.Average(W => W.Length);
            //Console.WriteLine(avg);


            //var result = ProductList.Select(P => P.Category).Distinct()
            //                        .Select(C => new { CategoryName = C, UnitInStockForCategory = ProductList.Where(P => P.Category == C).Sum(P => P.UnitsInStock) });

            //var result = ProductList.Select(P => P.Category).Distinct()
            //                        .Select(C => new { CategoryName = C , CheapestPrice = ProductList.Where(P => P.Category == C).Min(P => P.UnitPrice) }).ToList();


            //var result = from P in ProductList
            //             let minPrice = (from x in ProductList
            //                             where x.Category == P.Category
            //                             select x.UnitPrice).Min()
            //             where P.UnitPrice == minPrice
            //             select new { P.Category, P.ProductName, P.UnitPrice };

            //var result = ProductList.Select(P => P.Category).Distinct()
            //                        .Select(C => new { CategoryName = C, MaxmimumPrice = ProductList.Where(P => P.Category == C).Max(P => P.UnitPrice) }).ToList();

            //var result = ProductList.Select(P => P.Category).Distinct()
            //                        .Select(C => new { 
            //                                            CategoryName = C,
            //                                            ProductName = ProductList.Where(P => P.Category == C).OrderByDescending(P => P.UnitPrice).First().ProductName,
            //                                            MaxmimumPrice = ProductList.Where(P => P.Category == C).Max(P => P.UnitPrice) 
            //                                         }
            //                                ).ToList();


            //var result = ProductList.Select(P => P.Category).Distinct()
            //                        .Select(C => new
            //                        {
            //                            CategoryName = C,
            //                            AvgPrice = ProductList.Where(P => P.Category == C).Average(P => P.UnitPrice)
            //                        });



            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region LINQ - Ordering Operators

            //var result = ProductList.OrderBy(P => P.ProductName).ToList();

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(X => X, StringComparer.OrdinalIgnoreCase);

            //var result = ProductList.OrderByDescending(P => P.UnitPrice);

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(X => X.Length).ThenBy(N => N, StringComparer.OrdinalIgnoreCase);

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(X => X.Length).ThenBy(N => N);

            //var result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(X => X);

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.Where(X => X[1] == 'i').Reverse();

            // -- LINQ – Transformation Operators

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region LINQ – Transformation Operators

            //var result = ProductList.Select(p => p.ProductName).ToList();

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(W => new { lower = W.ToLower(), upper = W.ToUpper()});

            //var result = ProductList.Select(P => new {P.ProductID, P.ProductName, price = P.UnitPrice});
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((N, I) => N == I);

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = from N1 in numbersA
            //             from N2 in numbersB
            //             where N1 < N2
            //             select new { N1, N2 };

            //var result = numbersA.SelectMany(A => numbersB.Where(B => A < B), (A, B) => new { A, B });

            //foreach (var item in result)
            //    Console.WriteLine($"{item.A} is less than {item.B}");


            //var result = from C in CustomerList
            //             from o in C.Orders
            //             where o.Total < 500
            //             select o;

            //var result = from C in CustomerList
            //             from o in C.Orders
            //             where o.OrderDate.Year >= 1998
            //             select o;

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

        }
    }
}
