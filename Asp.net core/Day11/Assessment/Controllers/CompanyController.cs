using Assessment.Models;
using Assessment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        [HttpGet("GetAllCompanies")]
        public IActionResult GetAllCompanies()
        {
            List<Company> companies = companyRepository.GetAllCompanies();
            return Ok(companies);
        }
        [HttpPost("InputCompany")]
        public IActionResult InputCompany(Company company)
        {
            if(ModelState.IsValid)
            {
                companyRepository.InputCompany(company);
                return Ok(company);
            }
            else { return BadRequest(); }
            
        }
        [HttpGet("GetCompanyById/{id}")]
        public IActionResult GetCompanyById(int id)
        {
            Company company=companyRepository.GetCompanyById(id);
            return Ok(company);
        }
        [HttpGet("GetCompaniesByCity/{city}")]
        public IActionResult GetCompaniesByCity(string city)
        {
            return StatusCode(200,companyRepository.GetCompaniesByCity(city));
        }
        [HttpDelete("DeleteCompany/{id}")]
        public void DeleteCompany(int id)
        {
            companyRepository.DeleteCompany(id);
        }

    }
}
