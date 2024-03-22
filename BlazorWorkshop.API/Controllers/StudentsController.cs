using BlazorWorkshop.API.Services.StudentService;
using BlazorWorkshop.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWorkshop.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(await _studentService.GetStudents());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            return Ok(await _studentService.GetStudent(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            return Ok(await _studentService.CreateStudent(student));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            return Ok(await _studentService.UpdateStudent(id, student));
        }
    }
}
