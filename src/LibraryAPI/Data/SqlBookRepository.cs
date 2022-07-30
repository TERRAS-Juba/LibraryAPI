using LibraryAPI.Models;
namespace LibraryAPI.Data
{
    public class SqlBookRepository : IBookRepository
    {
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>
            {
                new Book
            {
                BookID=1,
                Name="Le Fils du pauvre",
                Author="Mouloud Feraoun",
                Field="Roman",
                Year=1950,
                IsPraised=false,
                Loans=new List<Loan>()

            },
            new Book
            {
                BookID=2,
                Name="Les derniers jours d'un condamné",
                Author="Victor Hugo",
                Field="Roman",
                Year=1829,
                IsPraised=false,
                Loans=new List<Loan>()
            }
            };
        }

        public Book GetBookByID(int id)
        {
            return new Book
            {
                BookID = 1,
                Name = "Le Fils du pauvre",
                Author = "Mouloud Feraoun",
                Field = "Roman",
                Year = 1950,
                IsPraised = false,
                Loans = new List<Loan>()

            };
        }

        public bool saveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}