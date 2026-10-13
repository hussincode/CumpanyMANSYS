using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CumpanyMANSYS.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required, Range(1000,1000000000)]
        public decimal Budget { get; set; }
        [Required,ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department department { get; set; }
        public List<EmployeeProject> employeeProjects { get; set; }

    }
}
