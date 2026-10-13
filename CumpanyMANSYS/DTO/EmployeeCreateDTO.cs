using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CumpanyMANSYS.DTO
{
    public class EmployeeCreateDTO
    {
        [Required, MaxLength(150)]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Range(3000, 100000)]
        public decimal Salary { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required, ForeignKey("Department")]
        public int DepartmentId { get; set; }
    }
}
