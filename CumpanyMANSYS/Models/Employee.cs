using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CumpanyMANSYS.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string FullName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required, Range(3000, 100000)]
        public decimal Salary { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required, ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department department { get; set; }
        public List<EmployeeProject> employeeProjects  { get; set; }
    }
}
