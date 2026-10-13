using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CumpanyMANSYS.DTO
{
    public class ProjectCreateDTO
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required, Range(1000, 1000000000)]
        public decimal Budget { get; set; }
        [Required, ForeignKey("Department")]
        public int DepartmentId { get; set; }
    }
}
