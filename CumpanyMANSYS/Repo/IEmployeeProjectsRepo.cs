using System.ComponentModel.DataAnnotations;
using CumpanyMANSYS.Genaric;
using CumpanyMANSYS.Models;

namespace CumpanyMANSYS.Repo
{
    public interface IEmployeeProjectsRepo : IGenaricRepo<EmployeeProject>
    {
        public Task<EmployeeProject> AddWithValidations(EmployeeProject employeeProject);
        public Task<List<EmployeeProject>> GetByEmployeeId(int employeeId);
    }
}
