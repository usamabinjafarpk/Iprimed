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
            try
            {
                foreach (Company company in companies)
                {
                    if (company.CompanyId == CompanyId)
                    {
                        companies.Remove(company);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetAllCompanies()
        {
            try
            {
                return companies;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetCompaniesByCity(string city)
        {
            List<Company> result = new List<Company>();
            try
            {
                foreach (Company company in companies)
                {
                    if (company.City.Equals(city))
                    {
                        result.Add(company);
                    }
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Company GetCompanyById(int id)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        public void InputCompany(Company company)
        {
            try
            {
                companies.Add(company);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
