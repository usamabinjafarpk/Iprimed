using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace HandsOnEFCodeFirstDemo2.Entities
{
    public class MyContext:DbContext
    {
        private readonly IConfiguration configuration;

        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Marks> Mark { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
            //optionsBuilder.UseSqlServer(@"Data Source=INTERNS107\SQL2022;Initial Catalog=SMSDB;Integrated Security=True;Trust Server Certificate=True");
           
        }
    }
}
