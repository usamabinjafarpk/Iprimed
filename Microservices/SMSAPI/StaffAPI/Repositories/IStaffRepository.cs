using StaffAPI.Models;

namespace StaffAPI.Repositories
{
    public interface IStaffRepository
    {
        void AddStaff(Staff staff);
        void UpdateStaff(Staff staff);
        void DeleteStaff(String id);
        List<Staff> GetAll();
        List<Staff> GetStaffByStd(string std);
        List<Staff> GetStaffBySub(string sub);
        List<Staff> GetStaffById(string staffid);
    }
}
