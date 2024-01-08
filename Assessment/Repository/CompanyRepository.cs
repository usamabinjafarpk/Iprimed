using Assessment.Models;

namespace Assessment.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        
        public List<Company> companies = new List<Company>()
        {
            new Company(){CompanyId=1,Name="RM",Address="Technopark",City="TVM"}
        };
        public void DeleteCompany(int CompanyId)
        {
            foreach (Company company in companies)
            {
                if(company.CompanyId == CompanyId)
                {
                    companies.Remove(company);
                }
            }
        }

        public List<Company> GetAllCompanies()
        {
            return companies;
        }

        public List<Company> GetCompaniesByCity(string city)
        {
            List<Company> result = new List<Company>();
            foreach (Company company in companies)
            {
                if (company.City.Equals(city))
                {
                    result.Add(company);
                }
            }
            return result;
        }

        public Company GetCompanyById(int id)
        {
            foreach (Company company in companies)
            {
                if (company.CompanyId.Equals(id))
                {
                    return company;
                }
            }
            return null;
        }

        public void InputCompany(Company company)
        {
            companies.Add(company);
        }
    }
}
