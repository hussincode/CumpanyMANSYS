using CumpanyMANSYS.Genaric;
using CumpanyMANSYS.Models;

namespace CumpanyMANSYS.Repo
{
    public interface IEmployeesRepo : IGenaricRepo<Employee>
    {
        public Task<Employee> SearchByName(string name);
        public Task<List<Employee>> GetByDepartmentId(int departmentId);
    }
}
