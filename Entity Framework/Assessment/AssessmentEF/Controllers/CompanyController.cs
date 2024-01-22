using AssessmentEF.Entities;
using AssessmentEF.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private CompanyRepository companyRepository;

        public CompanyController(CompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }
        [HttpPost,Route("AddCompany")]
        public IActionResult AddCompany(Company company)
        {
            try
            {
                companyRepository.Add(company);
                return Ok(company);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetAllCompany")]
        public IActionResult GetAllCompany()
        {
            try
            {
                return Ok(companyRepository.GetAllCompanies());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetCompanyByCity")]
        public IActionResult GetCompanyByCity(string city)
        {
            try
            {
                return Ok(companyRepository.GetCompanyByCity(city));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetCompanyByName")]
        public IActionResult GetCompanyByName(string name)
        {
            try
            {
                return Ok(companyRepository.GetCompanyByName(name));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("UpdateCompany")]
        public IActionResult UpdateCompany(Company company)
        {
            try
            {
                companyRepository.Update(company);
                return Ok(company);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteCompany")]
        public IActionResult DeleteCompany(int companyId)
        {
            try
            {
                companyRepository.Delete(companyId);
                return Ok("Company Deleted Successfully");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
