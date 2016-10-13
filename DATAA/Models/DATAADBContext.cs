using System.Data.Entity;

namespace DATAA.Models
{
    public class DATAADBContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}