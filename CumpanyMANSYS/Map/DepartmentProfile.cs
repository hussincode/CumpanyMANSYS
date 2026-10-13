using AutoMapper;
using CumpanyMANSYS.DTO;
using CumpanyMANSYS.Models;

namespace CumpanyMANSYS.Map
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentCreateDTO, Department>();
            CreateMap<Department, DepartmentDTO>();
        }
    }
}
