using LibraryAPI.Models;
namespace LibraryAPI.Data
{
    public interface IBookRepository
    {
        bool saveChanges();
        IEnumerable<Book> GetAllBooks();
        Book GetBookByID(int id);
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}