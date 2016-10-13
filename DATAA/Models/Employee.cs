
namespace DATAA.Models
{
    public class Employee
    {
        // Scalar Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string JobTitle { get; set; }

        // Navigation Property
        public Department Department { get; set; }
    }
}