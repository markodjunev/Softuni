namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(db);
                
            }

        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var sb = new StringBuilder();

            var bookTitles = context.Books
                .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(b => new
                {
                    BookTitle = b.Title,
                })
                .OrderBy(b => b.BookTitle)
                .ToList();

            foreach (var book in bookTitles)
            {
                sb.AppendLine(book.BookTitle);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var booksTitles = context.Books
                .Where(b => b.EditionType.ToString() == "Gold" && b.Copies < 5000)
                .Select(b => new
                {
                    b.Title,
                    b.BookId
                })
                .OrderBy(b => b.BookId)
                .ToList();

            foreach (var book in booksTitles)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Price,
                    b.Title
                })
                .OrderByDescending(b => b.Price)
                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .Select(b => new
                {
                    b.Title,
                    b.BookId
                })
                .OrderBy(b => b.BookId)
                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var categories = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var booksTitles = new List<string>();

            foreach (var category in categories)
            {
                var books = context.Books
                    .Where(b => b.BookCategories
                    .Any(bc => bc.Category.Name.ToLower() == category.ToLower()))
                    .Select(b => new
                    {
                        b.Title
                    })
                    .OrderBy(b => b.Title)
                    .ToList();

                foreach (var book in books)
                {
                    booksTitles.Add(book.Title);
                }
            }

            foreach (var book in booksTitles.OrderBy(t => t))
            {
                sb.AppendLine(book);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.ReleaseDate < DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture))
                .Select(b => new
                {
                    b.Title,
                    Edition = b.EditionType.ToString(),
                    b.Price,
                    b.ReleaseDate
                })
                .OrderByDescending(b => b.ReleaseDate)
                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.Edition} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName
                })
                .OrderBy(a => a.FullName)
                .ToList();

            foreach (var author in authors)
            {
                sb.AppendLine(author.FullName);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => new
                {
                    b.Title
                })
                .OrderBy(b => b.Title)
                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    AuthorName = b.Author.FirstName + ' ' + b.Author.LastName
                })
                .OrderBy(b => b.BookId)
                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} ({book.AuthorName})");
            }

            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Select(b => new
                {
                    b.BookId
                })
                .ToList();

            return books.Count();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var sb = new StringBuilder();

            var authors = context.Authors
                  .Select(a => new
                  {
                      AuthorName = a.FirstName + " " + a.LastName,
                      BooksCount = a.Books.Sum(c => c.Copies)
                  })
                  .OrderByDescending(c => c.BooksCount)
                  .ToList();

            foreach (var author in authors)
            {
                sb
                    .AppendLine($"{author.AuthorName} - {author.BooksCount}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categoryAnPrices = context.Categories
                .Select(bc => new
                {
                    CategoryName = bc.Name,
                    TotalProfit = bc.CategoryBooks
                    .Sum(c => c.Book.Price * c.Book.Copies)
                })
                .OrderByDescending(bc => bc.TotalProfit)
                .ThenBy(bc => bc.CategoryName)
                .ToList();

            foreach (var cp in categoryAnPrices)
            {
                sb
                    .AppendLine($"{cp.CategoryName} ${cp.TotalProfit}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categories = context.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    CategoryName = c.Name,
                    BookNames = c.CategoryBooks
                   .Select(b => new
                   {
                       BookTitle = b.Book.Title,
                       BookReleaseDate = b.Book.ReleaseDate,
                       BookReleaseYear = b.Book.ReleaseDate.Value.Year
                   })
                   .OrderByDescending(b => b.BookReleaseDate)
                   .Take(3)
                   .ToList()
                })
                .ToList();

            foreach (var category in categories)
            {
                sb
                    .AppendLine($"--{category.CategoryName}");

                foreach (var book in category.BookNames)
                {
                    sb
                        .AppendLine($"{book.BookTitle} ({book.BookReleaseYear})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010);


            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies < 4200);

            int count = books.Count();

            foreach (var book in books)
            {
                context.Remove(book);
            }

            context.SaveChanges();

            return count;
        }
    }
}