using System.ComponentModel.DataAnnotations;

namespace BlazorWorkshop.Shared.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
