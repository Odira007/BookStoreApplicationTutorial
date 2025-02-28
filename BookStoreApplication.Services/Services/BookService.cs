using BookStoreApplication.Services.Interfaces;
using BookStoreApplication.Entities;
using BookStoreApplication.Entities.Dtos;

namespace BookStoreApplication.Services.Services
{
    public class BookService : IBookService
    {
        public static int id = 0;

        // CRUD = CREATE, READ, UPDATE, DELETE


        // CREATE
        public void Create(BookCreationDto bookCreationDto)
        {
            Book book = new Book(
                ++id, 
                bookCreationDto.Title, 
                bookCreationDto.Description, 
                bookCreationDto.TotalPages
            );

            DataBase.DataStore.books.Add( book );
        }

        // READ
        public List<Book> GetBooks()
        {
            if (DataBase.DataStore.books.Count() > 0)
            {
                return DataBase.DataStore.books;
            }
            return new List<Book>();
        }
    }
}
