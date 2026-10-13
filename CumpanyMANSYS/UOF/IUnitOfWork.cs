using CumpanyMANSYS.Genaric;
using CumpanyMANSYS.Models;
using CumpanyMANSYS.Repo;

namespace CumpanyMANSYS.UOF
{
    public interface IUnitOfWork
    {
        IGenaricRepo<Department> Department { get; }
        IEmployeesRepo Employee { get; }
        IGenaricRepo<Project> Project { get; }
        IGenaricRepo<EmployeeProject> EmployeeProject { get; }
        Task Save();
    }
}
