using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CumpanyMANSYS.Models
{
    [Index(nameof(EmployeeId), nameof(ProjectId), IsUnique = true)]
    public class EmployeeProject
    {
        [Key]
        public int Id { get; set; }
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
