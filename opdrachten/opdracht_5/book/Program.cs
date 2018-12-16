using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create author
            Author author1 = new Author();
            author1.Name = "George Orwell";
            author1.Email = "orwell@gmail.com";
            author1.Gender = 'M';

            // Create book
            Book book1 = new Book("1984 ", author1, 15.00, 8);

            // Setters
            book1.setPrice(20.00);
            book1.setQtyInStock(2);
            book1.print();
        }
    }
}
