using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public int TotalPages { get; set; }
        public int AuthorId { get; set; }

        public Book(int id, string title, string desc, int totalPages)
        {
            Id = id;
            Title = title;
            Description = desc;
            TotalPages = totalPages;
        }
    }
}
