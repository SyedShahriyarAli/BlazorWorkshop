using BlazorWorkshop.API.Data;
using BlazorWorkshop.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkshop.API.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DataContext _context;

        public DepartmentService(DataContext context)
        {
            _context = context;
        }

        public async Task<GenericResponse<Department>> CreateDepartment(Department department)
        {
            var response = new GenericResponse<Department>();

            try
            {
                await _context.Departments.AddAsync(department);
                await _context.SaveChangesAsync();

                response.Data = department;
                response.Message = "Department created successfully.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GenericResponse<Department>> GetDepartmentById(int id)
        {
            var response = new GenericResponse<Department>();

            try
            {
                var department = await _context.Departments.FindAsync(id) ?? throw new Exception("Department not found");

                response.Data = department;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GenericResponse<List<Department>>> GetDepartments()
        {
            var response = new GenericResponse<List<Department>>();

            try
            {
                response.Data = await _context.Departments.ToListAsync();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GenericResponse<Department>> UpdateDepartment(int id, Department department)
        {
            var resposne = new GenericResponse<Department>();

            try
            {
                var existingDepartment = await _context.Departments.FindAsync(id);

                if (existingDepartment == null)
                    throw new Exception("Department not found");

                existingDepartment.Name = department.Name;
                existingDepartment.IsActive = department.IsActive;

                await _context.SaveChangesAsync();

                resposne.Data = existingDepartment;
                resposne.Message = "Department updated successfully.";
            }
            catch (Exception ex)
            {
                resposne.Success = false;
                resposne.Message = ex.Message;
            }

            return resposne;
        }
    }
}
