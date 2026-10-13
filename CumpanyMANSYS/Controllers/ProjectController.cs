using AutoMapper;
using CumpanyMANSYS.DTO;
using CumpanyMANSYS.Models;
using CumpanyMANSYS.UOF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CumpanyMANSYS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public ProjectController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects = await unitOfWork.Project.GetAll();
            return Ok(projects);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await unitOfWork.Project.Get(id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProjectCreateDTO project)
        {
            var data = mapper.Map<Project>(project);
            await unitOfWork.Project.Add(data);
            await unitOfWork.Save();
            return Ok(project);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProjectCreateDTO project)
        {
            var mapp = await unitOfWork.Project.Get(id);
            var data = mapper.Map(project, mapp);
            await unitOfWork.Project.Update(id, data);
            await unitOfWork.Save();
            return Ok(project);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            unitOfWork.Project.Delete(id);
            await unitOfWork.Save();
            return Ok();
        }
    }
}
