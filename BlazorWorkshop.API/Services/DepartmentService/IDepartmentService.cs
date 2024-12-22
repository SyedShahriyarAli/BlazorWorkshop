using BlazorWorkshop.Shared.Models;

namespace BlazorWorkshop.API.Services.DepartmentService
{
    public interface IDepartmentService
    {
        Task<GenericResponse<List<Department>>> GetDepartments();
        Task<GenericResponse<Department>> GetDepartmentById(int id);
        Task<GenericResponse<Department>> CreateDepartment(Department department);
        Task<GenericResponse<Department>> UpdateDepartment(int id, Department department);
    }
}