using System.ComponentModel.DataAnnotations;

namespace BlazorWorkshop.Shared.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}