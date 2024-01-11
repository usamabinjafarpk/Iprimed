using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaffAPI.Models;
using StaffAPI.Repositories;

namespace StaffAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepository staffRepository;

        public StaffController(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }
        [HttpGet, Route("GetAllStaffs")]
        public IActionResult Get()
        {
            try
            {
                return Ok(staffRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetAllStaffByStd/{std}")]
        public IActionResult GetAllByStd(string std)
        {
            try
            {
                return Ok(staffRepository.GetStaffByStd(std));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetAllStaffBySubject/{Subject}")]
        public IActionResult GetAllBySubject(string subject)
        {
            try
            {
                return Ok(staffRepository.GetStaffBySub(subject));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetStaff/{id}")]
        public IActionResult GetStaff(string id)
        {
            try
            {
                return Ok(staffRepository.GetStaffById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("AddStaff")]
        public IActionResult Staff(Staff staff)
        {
            try
            {
                staffRepository.AddStaff(staff);
                return Ok(staff);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("EditStaff")]
        public IActionResult Edit(Staff staff)
        {
            try
            {
                staffRepository.UpdateStaff(staff);
                return Ok(staff);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete, Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                staffRepository.DeleteStaff(id);
                return Ok("Staff Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}