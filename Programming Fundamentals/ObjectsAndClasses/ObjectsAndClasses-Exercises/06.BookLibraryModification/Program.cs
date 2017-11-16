﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _06.BookLibraryModification
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = GetBooks();
            DateTime targetReleaseDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            DateTime[] resultReleaseDate = books.Where(x => x.ReleaseDate > targetReleaseDate)
                .Select(x => x.ReleaseDate).Distinct()
                .OrderBy(x => x)
                .ToArray();
            foreach (DateTime releaseDate in resultReleaseDate)
            {
                string[] releaseDateTitles = books.Where(x => x.ReleaseDate == releaseDate)
                    .Select(x => x.Title).Distinct()
                    .OrderBy(x => x)
                    .ToArray();
                foreach (string title in releaseDateTitles)
                {
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", title, releaseDate);
                }
            }
        }

        private static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                books.Add(new Book()
                {
                    Title = data[0],
                    Author = data[1],
                    Publisher = data[2],
                    ReleaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = data[4],
                    Price = decimal.Parse(data[5])
                });
            }
            return books;
        }
    }
}
