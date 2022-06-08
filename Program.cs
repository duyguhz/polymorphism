using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book()
            {
                Name = "Martin Eden",
                Price = 12,
                Author = "Jack London",
                Genre = "novel"

            };
            Book book2 = new Book()
            {
                Name = "1984",
                Price = 14,
                Author = "George Orwell",
                Genre = "fiction"

            };
            Journal journal = new Journal()
            {
                Name = "Covid-19",
                Price = 32,
                Company = "Oxford Academic"

            };

            library.AddProduct(book1);
            library.AddProduct(book2);
            library.AddProduct(journal);

            Console.WriteLine(library.GetBooksCount());
        }
    }
}
