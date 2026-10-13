using System.ComponentModel.DataAnnotations;

namespace CumpanyMANSYS.DTO
{
    public class DepartmentCreateDTO
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Location { get; set; }
    }
}
