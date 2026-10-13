using CumpanyMANSYS.Data;
using CumpanyMANSYS.Genaric;
using CumpanyMANSYS.Models;
using CumpanyMANSYS.Repo;

namespace CumpanyMANSYS.UOF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dataContext;
        public IGenaricRepo<Department> Department { get; }
        public IEmployeesRepo Employee { get; }
        public IGenaricRepo<Project> Project { get; }
        public IGenaricRepo<EmployeeProject> EmployeeProject { get; }
        public UnitOfWork(IGenaricRepo<Department> department,
            IEmployeesRepo employee,
            IGenaricRepo<Project> project, 
            IGenaricRepo<EmployeeProject> employeeProject,
            DataContext dataContext)
        {
            Department = department;
            Employee = employee;
            Project = project;
            EmployeeProject = employeeProject;
            this.dataContext = dataContext;
        }

        public async Task Save()
        {
             await dataContext.SaveChangesAsync();
        }
    }
}
