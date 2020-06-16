using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Nemože duže od 50 karaktera")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Office Email")]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }
    }
}
