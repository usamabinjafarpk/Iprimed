using Assessment.Models;

namespace Assessment.Repository
{
    public interface ICompanyRepository
    {
       
        void InputCompany(Company company);
        List<Company> GetAllCompanies();
        List<Company> GetCompaniesByCity(string city);
        Company GetCompanyById(int id);
        void DeleteCompany(int CompanyId);

    }
}
