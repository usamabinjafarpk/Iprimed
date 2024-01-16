using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIWithEFCodeFirstDemo1.Entities
{
    public class MyContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=INTERNS107\SQL2022;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
