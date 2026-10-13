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
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await unitOfWork.Employee.GetAll();
            return Ok(employees);
        }
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeCreateDTO employee)
        {
            var data = mapper.Map<Employee>(employee);
            await unitOfWork.Employee.Add(data);
            await unitOfWork.Save();
            return Ok(employee);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await unitOfWork.Employee.Get(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, EmployeeCreateDTO employee)
        {
            var mapp = await unitOfWork.Employee.Get(id);
            var data = mapper.Map(employee, mapp);
            await unitOfWork.Employee.Update(id, data);
            await unitOfWork.Save();
            return Ok(employee);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            unitOfWork.Employee.Delete(id);
            await unitOfWork.Save();
            return Ok();
        }
        [HttpGet("SearchByName/{Name}")]
        public async Task<IActionResult> SearchByName(string Name)
        {
            var employees = await unitOfWork.Employee.SearchByName(Name);
            return Ok(employees);
        }
        [HttpGet("SearchByDepartment/{DepartmentId}")]
        public async Task<IActionResult> SearchById(int DepartmentId)
        {
            var employees = await unitOfWork.Employee.GetByDepartmentId(DepartmentId);
            return Ok(employees);
        }
    }
}
