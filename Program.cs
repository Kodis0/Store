using System;
using StoreLib;

namespace Program
{

    public class Book
    {
        public string Title { get; }

        public int Id { get; }

        public string Author { get; }

        public int Year { get; }

        public string Publish { get; }

        public string Describe { get; }

        public int Price { get; }

        public Book(string title, int id, string author, int year, string publish, string describe, int price)
        {
            Title = title;
            Id = id;
            Author = author;
            Year = year;
            Publish = publish;
            Describe = describe;
            Price = price;
        }
        static void Main(string[] args)
        {
            // Создаем экземпляр BookRepository
            BookRepository bookRepository = new BookRepository();

            // Получаем список всех книг
            List<Book> allBooks = bookRepository.GetAllBooks();
            Console.WriteLine("Список всех книг:");
            foreach (var book in allBooks)
            {
                Console.WriteLine($"Название: {book.Title}\n\n Автор: {book.Author}\n Год издания: {book.Year}\n Издательство: {book.Publish}\n Стоимость: {book.Price}\n\n Описание: {book.Describe}\n\n");
            }
        }
    }


}