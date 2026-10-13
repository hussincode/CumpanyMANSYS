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
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DepartmentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Add(DepartmentCreateDTO departmentCreateDTO)
        {
            var department = mapper.Map<Department>(departmentCreateDTO);
           await unitOfWork.Department.Add(department);
            unitOfWork.Save();
            return Ok(department);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await unitOfWork.Department.GetAll();
            var departmentDTOs = mapper.Map<IEnumerable<DepartmentDTO>>(departments);
            return Ok(departmentDTOs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var department = await unitOfWork.Department.Get(id);
            if (department == null)
            {
                return NotFound();
            }
            var departmentDTO = mapper.Map<DepartmentDTO>(department);
            return Ok(departmentDTO);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DepartmentCreateDTO departmentCreateDTO)
        {
            var mappedDepartment = await unitOfWork.Department.Get(id);
            var department = mapper.Map(departmentCreateDTO, mappedDepartment);
            await unitOfWork.Department.Update(id, department);
            await unitOfWork.Save();
            return Ok(department);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
             unitOfWork.Department.Delete(id);
           
                
            await unitOfWork.Save();
            return NoContent();
        }
    }
}
