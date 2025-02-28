using BookStoreApplication.Services.Interfaces;
using BookStoreApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly BooksViewModel _booksViewModel;

        public BookController(IBookService bookService, BooksViewModel booksViewModel)
        {
            _bookService = bookService;
            _booksViewModel = booksViewModel;
        }


        public IActionResult BooksDisplay()
        {
            _booksViewModel.books = _bookService.GetBooks();
            return View(_booksViewModel);
        }
    }
}
