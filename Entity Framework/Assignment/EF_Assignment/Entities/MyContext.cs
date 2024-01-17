using Microsoft.EntityFrameworkCore;
namespace EF_Assignment.Entities
{
    public class MyContext:DbContext
    {
        private readonly IConfiguration _configuration;

        public MyContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Book> books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyConnection"));
            //optionsBuilder.UseSqlServer("Data Source=INTERNS107\\SQL2022;Initial Catalog=EFAssignmentDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
