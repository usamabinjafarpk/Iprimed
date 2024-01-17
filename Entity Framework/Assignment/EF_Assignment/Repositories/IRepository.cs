namespace EF_Assignment.Repositories
{
    public interface IRepository<T> where T : class
    {
        void AddBook(T entity);
        List<T> GetAll();
        List<T> GetBooksByAuthor(string author);
        List<T> GetBooksByLang(string lang);
        List<T> GetBooksByYear(int year);
        void EditBook(T entity);
        void DeleteBook(int id);
    }
}
