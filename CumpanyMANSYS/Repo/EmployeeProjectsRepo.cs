using AutoMapper;
using CumpanyMANSYS.Data;
using CumpanyMANSYS.Genaric;
using CumpanyMANSYS.Map;

namespace CumpanyMANSYS.Repo
{
    public class EmployeeProjectsRepo : GenaricRepo<EmployeeProfile>, IEmployeeProjectsRepo
    {
        private readonly DataContext _context;
        public EmployeeProjectsRepo(DataContext context, IMapper mapper) : base(context)
        {
            _context = context;
        }

    }
}
