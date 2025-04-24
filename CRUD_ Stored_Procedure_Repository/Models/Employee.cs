using System.ComponentModel.DataAnnotations;

namespace CRUD__Stored_Procedure_Repository.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; //here we are using string.Empty to avoid null reference exception
        public string Email { get; set; } = string.Empty;
    }
}
