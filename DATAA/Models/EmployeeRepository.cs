using System.Collections.Generic;
using System.Linq;

namespace DATAA.Models
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            DATAADBContext employeeDBContext = new DATAADBContext();
            return employeeDBContext.Departments.Include("Employees").ToList();
        }
    }
}