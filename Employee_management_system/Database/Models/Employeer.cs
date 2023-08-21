using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_management_system.Database.Models
{
    [Table("Employeers")]
    public class Employeer
    {


        public Employeer(string name, string surname, string fatherName, string pINcode, string email, string photo, string departament, string employeerCode, bool isDeleted)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            PINcode = pINcode;
            Email = email;
            Photo = photo;
            Departament = departament;
            EmployeerCode = employeerCode;
            IsDeleted = isDeleted;
        }

        
        public Employeer() { }

        [Key]
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Surname { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FatherName { get; set; }
        [Required]
        public string PINcode { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string Departament { get; set; }
        public string EmployeerCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
