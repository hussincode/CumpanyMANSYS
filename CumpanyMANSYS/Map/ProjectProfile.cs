using AutoMapper;
using CumpanyMANSYS.DTO;
using CumpanyMANSYS.Models;

namespace CumpanyMANSYS.Map
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectCreateDTO, Project>();
            CreateMap<Project, ProjectDTO>();
        }   
    }
}
