using CumpanyMANSYS.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CumpanyMANSYS.Controllers
{
    public class EmployeeProjectsDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        public int ProjectId { get; set; }
        public Project project { get; set; }
        public string AssignedRole { get; set; }
        public DateTime AssignedDate { get; set; }
    }
}
