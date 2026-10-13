using System.ComponentModel.DataAnnotations;

namespace CumpanyMANSYS.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Location { get; set; }
        public List<Employee> employees { get; set; }
        public List<Project> projects { get; set; }
    }
}
