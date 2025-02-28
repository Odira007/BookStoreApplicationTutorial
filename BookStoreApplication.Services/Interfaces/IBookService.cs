using BookStoreApplication.Entities;
using BookStoreApplication.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Services.Interfaces
{
    public interface IBookService
    {
        void Create(BookCreationDto bookCreationDto);

        List<Book> GetBooks();
    }
}
