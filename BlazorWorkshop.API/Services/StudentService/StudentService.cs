using BlazorWorkshop.API.Data;
using BlazorWorkshop.Shared.Dtos;
using BlazorWorkshop.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkshop.API.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;

        public StudentService(DataContext context)
        {
            _context = context;
        }

        public async Task<GenericeResponse<Student>> CreateStudent(Student student)
        {
            GenericeResponse<Student> response = new();

            try
            {
                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();

                response.Message = "Student created successfully";
                response.Data = student;
            }
            catch (System.Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GenericeResponse<Student>> GetStudent(int id)
        {
            GenericeResponse<Student> response = new();

            try
            {
                var student = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);

                if (student == null)
                {
                    response.Success = false;
                    response.Message = "Student not found";
                }
                else
                {
                    response.Data = student;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GenericeResponse<List<StudentDto>>> GetStudents()
        {
            GenericeResponse<List<StudentDto>> response = new();

            try
            {
                var students = _context.Students.Select(x => new StudentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Email = x.Email
                }).ToList();

                response.Data = students;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GenericeResponse<Student>> UpdateStudent(int id, Student student)
        {
            GenericeResponse<Student> response = new();

            try
            {
                _context.Entry(student).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                response.Data = student;
                response.Message = "Student updated successfully";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
