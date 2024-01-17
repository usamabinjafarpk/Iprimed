using EF_Assignment.Entities;

namespace EF_Assignment.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private readonly MyContext _context;

        public BookRepository(MyContext context)
        {
            _context = context;
        }

        /* public BookRepository()
         {
             _context = new MyContext();
         }*/

        public void AddBook(Book entity)
        {
            _context.books.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            Book book = _context.books.Find(id);
            _context.books.Remove(book);
            _context.SaveChanges();
        }

        public void EditBook(Book entity)
        {
            _context.books.Update(entity);
            _context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _context.books.ToList();
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return _context.books.Where(b => b.Author == author).ToList();
        }

        public List<Book> GetBooksByLang(string lang)
        {
            return _context.books.Where(b => b.Lang == lang).ToList();
        }

        public List<Book> GetBooksByYear(int year)
        {
            return _context.books.Where(b => b.ReleaseDate.Year == year).ToList();
        }
    }
}
