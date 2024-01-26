using AssessmentEF.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;

namespace AssessmentEF.Repositories
{
    public interface ICompanyRepository
    {
        void Add(Company company);
        List<Company> GetAllCompanies();
        List<Company> GetCompanyByCity(string city);
        Company GetCompanyByName(string name);
        void Update(Company company);
        void Delete(int id);
    }
}
