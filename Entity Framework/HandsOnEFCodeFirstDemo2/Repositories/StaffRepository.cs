using HandsOnEFCodeFirstDemo2.Entities;

namespace HandsOnEFCodeFirstDemo2.Repositories
{
    public class StaffRepository : IRepository<Staff>
    {
        private readonly MyContext _context;

        public StaffRepository()
        {
            _context = new MyContext();
        }

        public void Add(Staff entity)
        {
            _context.Staffs.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Staff staff = _context.Staffs.Find(id);
            _context.Staffs.Remove(staff);
            _context.SaveChanges();
        }

        public Staff Get(int id)
        {
            return _context.Staffs.Find(id);
        }

        public List<Staff> GetAll()
        {
            return _context.Staffs.ToList();
        }

        public void Update(Staff entity)
        {
            _context.Staffs.Update(entity);
            _context.SaveChanges();
        }
    }
}
