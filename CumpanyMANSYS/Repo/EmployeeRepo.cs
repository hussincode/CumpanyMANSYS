using CumpanyMANSYS.Data;
using CumpanyMANSYS.Genaric;
using CumpanyMANSYS.Models;
using Microsoft.EntityFrameworkCore;

namespace CumpanyMANSYS.Repo
{
    public class EmployeeRepo : GenaricRepo<Employee>, IEmployeesRepo
    {
        private readonly DataContext dataContext1;
        public EmployeeRepo(DataContext dataContext) : base(dataContext)
        {
            dataContext1 = dataContext;
        }

        public async Task<List<Employee>> GetByDepartmentId(int departmentId)
        {
            return await dataContext1.Employees.Where(e => e.DepartmentId == departmentId).ToListAsync();
        }

        

        public async Task<Employee> SearchByName(string name)
        {
            return await dataContext1.Employees.FirstOrDefaultAsync(e => e.FullName.Contains(name));
        }
    }
}
