using StaffAPI.Models;

namespace StaffAPI.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        List<Staff> staffs = new List<Staff>();
        public void AddStaff(Staff staff)
        {
            staffs.Add(staff);
        }

        public void DeleteStaff(String id)
        {
            var s = staffs.SingleOrDefault(s => s.StaffId == id);
            staffs.Remove(s);
        }

        public List<Staff> GetAll()
        {
            return staffs;
        }

        public List<Staff> GetStaffById(string staffid)
        {
            return staffs.Where(s => s.StaffId == staffid).ToList();
        }

        public List<Staff> GetStaffByStd(string std)
        {
            List<Staff> bystd = (from f in staffs
                                 where f.Stds.Contains(std)
                                 select f).ToList();
            return bystd;


            /*  List<Staff> bystd= new List<Staff>();
             foreach(var s in staffs) 
              {
                  foreach(var s1 in s.Stds)
                  {
                      if (s1 == std)
                      {
                          bystd.Add(s);
                      }
                  }
              }
             return bystd;*/
        }

        public List<Staff> GetStaffBySub(string sub)
        {
            List<Staff> bysub = (from f in staffs
                                 where f.Subjects.Contains(sub)
                                 select f).ToList();
            return bysub;
            /* List<Staff> bysub = new List<Staff>();
             foreach (var s in staffs)
             {
                 foreach (var s1 in s.Subjects)
                 {
                     if (s1 == sub)
                     {
                         bysub.Add(s);
                     }
                 }
             }
             return bysub;*/
        }

        public void UpdateStaff(Staff staff)
        {
            var res = staffs.SingleOrDefault(s => s.StaffId == staff.StaffId);
            if (res != null)
            {
                res.Stds = staff.Stds;
                res.Subjects = staff.Subjects;
                res.Name = staff.Name;
            }
        }
    }
}
