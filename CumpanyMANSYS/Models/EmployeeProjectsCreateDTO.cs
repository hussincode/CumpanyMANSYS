using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CumpanyMANSYS.Models
{
    public class EmployeeProjectsCreateDTO
    {
        [Required, ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        [Required, ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project project { get; set; }
        [Required, MaxLength(50)]
        public string AssignedRole { get; set; }
        [Required]
        public DateTime AssignedDate { get; set; }
    }
}
