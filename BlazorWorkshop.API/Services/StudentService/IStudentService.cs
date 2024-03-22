using BlazorWorkshop.Shared.Dtos;
using BlazorWorkshop.Shared.Models;

namespace BlazorWorkshop.API.Services.StudentService
{
    public interface IStudentService
    {
        Task<GenericeResponse<List<StudentDto>>> GetStudents();
        Task<GenericeResponse<Student>> GetStudent(int id);
        Task<GenericeResponse<Student>> CreateStudent(Student student);
        Task<GenericeResponse<Student>> UpdateStudent(int id, Student student);
    }
}
