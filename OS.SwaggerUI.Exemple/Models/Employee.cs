using System.ComponentModel.DataAnnotations;

namespace OS.SwaggerUI.Exemple.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string EmailId { get; set; }
    }
}
