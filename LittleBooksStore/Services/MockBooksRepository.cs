using LittleBooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBooksStore.Services
{
    public class MockBooksRepository : IRepository<Book>
    {
        private List<Book> _book;

        public bool Add(Book item)
        {
            try
            {
                Book Book = item;
                Book.Id = _book.Max(id => id.Id) + 1;
                _book.Add(Book);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(Book item)
        {
            try
            {
                _book.Remove(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            return _book.ToList();
        }

        public Book Get(int id)
        {
            return _book.FirstOrDefault(book => book.Id == id);
        }


        public MockBooksRepository()
        { 
            _book = new List<Book>();
            _book.Add(
                new Book()
                {
                    Id = 1,
                    Title = "The Witcher 3",
                    Description = "Geralt the Wolf of Rivia",
                    Author = "Fausio Matsinhe",
                    PublishDate = "July, 2018",
                    Price = 39.01,
                    image = "b1.png"
                });

            _book.Add(
                 new Book()
                 {
                     Id = 2,
                     Title = "The Hobbit",
                     Description = "Lord of the rings",
                     Author = "Carlos Uchia",
                     PublishDate = "Jan, 2020",
                     Price = 39.01,
                     image = "b2.png"
                 });
            _book.Add(
                new Book()
                {
                    Id = 3,
                    Title = "The Hobbit",
                    Description = "Lord of the rings",
                    Author = "Carlos Uchia",
                    PublishDate = "Jan, 2020",
                    Price = 39.01,
                    image = "b3.png"
                });
            _book.Add(
                new Book()
                {
                    Id = 4,
                    Title = "The Hobbit",
                    Description = "Lord of the rings",
                    Author = "Carlos Uchia",
                    PublishDate = "Jan, 2020",
                    Price = 39.01,
                    image = "b4.png"
                });
            _book.Add(
                new Book()
                {
                    Id = 5,
                    Title = "The Hobbit",
                    Description = "Lord of the rings",
                    Author = "Carlos Uchia",
                    PublishDate = "Jan, 2020",
                    Price = 39.01,
                    image = "b5.png"
                });
            _book.Add(
                new Book()
                {
                    Id = 6,
                    Title = "The Hobbit",
                    Description = "Lord of the rings",
                    Author = "Carlos Uchia",
                    PublishDate = "Jan, 2020",
                    Price = 39.01,
                    image = "b6.png"
                });
            _book.Add(
                new Book()
                {
                    Id = 7,
                    Title = "The Hobbit",
                    Description = "Lord of the rings",
                    Author = "Carlos Uchia",
                    PublishDate = "Jan, 2020",
                    Price = 39.01,
                    image = "b7.png"
                });
            _book.Add(
                new Book()
                {
                    Id = 8,
                    Title = "The Hobbit",
                    Description = "Lord of the rings",
                    Author = "Carlos Uchia",
                    PublishDate = "Jan, 2020",
                    Price = 39.01,
                    image = "b8.png"
                });
            
        }
    }
}
