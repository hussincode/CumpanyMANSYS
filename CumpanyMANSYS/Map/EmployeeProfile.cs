using AutoMapper;
using CumpanyMANSYS.DTO;
using CumpanyMANSYS.Models;

namespace CumpanyMANSYS.Map
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeCreateDTO, Employee>();
            CreateMap<Employee, EmployeeDTO>().ForMember(d => d.DepartmentId, o => o.MapFrom(s => s.department.Id));
        }
    }
}
