
namespace DATAA.WebApi.Models
{
    public class Documentation
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public bool IsActive { get; set; }
    }
}