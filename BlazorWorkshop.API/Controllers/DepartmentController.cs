using BlazorWorkshop.API.Services.DepartmentService;
using BlazorWorkshop.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWorkshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentSerivce;

        public DepartmentController(IDepartmentService departmentSerivce)
        {
            _departmentSerivce = departmentSerivce;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _departmentSerivce.GetDepartments());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _departmentSerivce.GetDepartmentById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment(Department department)
        {
            return Ok(await _departmentSerivce.CreateDepartment(department));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartment(int id, Department department)
        {
            return Ok(await _departmentSerivce.UpdateDepartment(id, department));
        }
    }
}
