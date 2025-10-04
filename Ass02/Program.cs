namespace Ass02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators

            // 1. Get first Product out of Stock 
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(result);

            // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);

            // 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(N => N > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);


            #endregion

            #region LINQ - Aggregate Operators

            // 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(N => N%2 == 1).Count();
            //Console.WriteLine(result);

            // 2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(C => new {CustomerName = C.CustomerName, OrdersCount = C.Orders.Count()});
            //foreach (var item in result)
            //    Console.WriteLine(item);


            // 3. Return a list of categories and how many products each has
            //var result = from P in ProductList
            //             group P by P.Category;
            //foreach (var category in result)
            //{
            //    Console.WriteLine($"Category : {category.Key}, numbers of products : {category.Count()}");
            //}

            // 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Sum(word => word.Length);
            //Console.WriteLine(result);

            //6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Min(x => x.Length);
            //Console.WriteLine(result);


            //7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Max(x => x.Length);


            //8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Average(x => x.Length);


            //9.Get the total units in stock for each product category.
            //var result = from P in ProductList
            //             group P by P.Category
            //             into C
            //             select new
            //             {
            //                 categoryName = C.Key,
            //                 totlaUnitPrice = C.Sum(P => P.UnitPrice)
            //             };

            //foreach (var item in result)
            //    Console.WriteLine(item);

            //10.Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(P => P.Category).Select(C => new { CategoryName = C.Key , MinPrice = C.Min(P => P.UnitPrice)});

            //foreach (var item in result)
            //    Console.WriteLine(item);


            //11.Get the products with the cheapest price in each category(Use Let)
            //var result = from P in ProductList
            //             group P by P.Category
            //             into C
            //             let minPrice = C.Min(P => P.UnitPrice)
            //             from product in C
            //             where product.UnitPrice == minPrice
            //             select product;

            //foreach (var item in result)
            //    Console.WriteLine(item);


            //12.Get the most expensive price among each category's products.
            //var result = from P in ProductList
            //             group P by P.Category into C
            //             select new
            //             {
            //                 category = C.Key,
            //                 MaxPrice = C.Max(P => P.UnitPrice)
            //             };
            //foreach (var item in result)
            //    Console.WriteLine(item);

            // 13. Get the products with the most expensive price in each category.
            //var result = from P in ProductList
            //             group P by P.Category into C
            //             let maxPrice = C.Max(P => P.UnitPrice)
            //             from product in C
            //             where product.UnitPrice == maxPrice
            //             select product;

            //foreach (var item in result)
            //    Console.WriteLine(item);


            // 14. Get the average price of each category's products.
            //var result = from P in ProductList
            //             group P by P.Category into C
            //             select new
            //             {
            //                 category = C.Key,
            //                 avgPrice = C.Average(P => P.UnitPrice)
            //             };
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region LINQ - Set Operators

            // 1. Find the unique Category names from Product List
            //var result = ProductList.Select(P => P.Category).Distinct().ToList();
            //foreach (var item in result)
            //    Console.WriteLine(item);

            // 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var merge = ProductList.Select(P => P.ProductName).Union(CustomerList.Select(P => P.CustomerName)).ToList();
            //var result = merge.Select(M => M[0]).Distinct();
            //foreach (var item in result)
            //    Console.WriteLine(item);


            // 3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductList.Select(P => P.ProductName[0]).Intersect(CustomerList.Select(P => P.CustomerName[0]));
            //foreach (var item in result)
            //    Console.WriteLine(item);

            // 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(P => P.ProductName[0]).Except(CustomerList.Select(C => C.CustomerName[0]));


            // 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList.Select(P => P.ProductName.TakeLast(3)).Concat(CustomerList.Select(C => C.CustomerName.TakeLast(3)));



            #endregion

            #region LINQ - Quantifiers

            // 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Where(W => W.Contains("ei"));
            //Console.WriteLine(result.Count()>0);

            // 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(P => P.Category).Where(C => C.Any(P => P.UnitsInStock == 0));
            //foreach (var category in result)
            //{
            //    Console.WriteLine($"category Name: {category.Key}");

            //    foreach (var item in category)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            // 3. Return a grouped a list of products only for categories that have all of their products in stock
            //var result = ProductList.GroupBy(P => P.Category).Where(C => C.All(P => P.UnitsInStock > 0));
            //foreach (var category in result)
            //{
            //    Console.WriteLine($"category Name: {category.Key}");

            //    foreach (var item in category)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}



            #endregion

            #region LINQ – Grouping Operators

            // 1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(N => N % 5).OrderBy(O => O.Key).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Number of the reminder of {item.Key} when divided by 5: ");

            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}

            // 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(W => W[0]).OrderBy(O => O.Key);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Words start with litter {item.Key} with count {item.Count()}: ");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}

            // 3.	Consider this Array as an Input

            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var result = Arr.GroupBy(W => W.Trim(), new StringCustomComparer());

            //foreach (var item in result)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.Write($"{item1} , ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
