using BookStoreApplication.Entities;

namespace BookStoreApplication.DataBase
{
    public class DataStore
    {
        public static List<Book> books = new List<Book>()
        {
            new Book(1, "There was a country", "A book By Chinua Achebe", 234),
            new Book(1, "Models", "Mark Manson", 871)
        };
    }
}
