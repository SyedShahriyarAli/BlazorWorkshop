using BlazorWorkshop.Shared.Dtos;
using BlazorWorkshop.Shared.Models;

namespace BlazorWorkshop.API.Services.StudentService
{
    public interface IStudentService
    {
        Task<GenericResponse<List<StudentDto>>> GetStudents();
        Task<GenericResponse<Student>> GetStudent(int id);
        Task<GenericResponse<Student>> CreateStudent(Student student);
        Task<GenericResponse<Student>> UpdateStudent(int id, Student student);
    }
}
