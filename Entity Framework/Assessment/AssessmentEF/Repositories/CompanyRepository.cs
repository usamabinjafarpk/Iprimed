using AssessmentEF.Entities;

namespace AssessmentEF.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly MyContext _context;

        public CompanyRepository(MyContext context)
        {
            _context = context;
        }

        public void Add(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Company company = _context.Companies.Find(id);
            _context.Companies.Remove(company);
            _context.SaveChanges();
        }

        public List<Company> GetAllCompanies()
        {
            return _context.Companies.ToList();
        }

        public List<Company> GetCompanyByCity(string city)
        {
            return _context.Companies.Where(c=>c.City==city).ToList();
        }

        public Company GetCompanyByName(string name)
        {
            return _context.Companies.Where(n=>n.Name==name).FirstOrDefault();
        }

        public void Update(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
        }
    }
}
