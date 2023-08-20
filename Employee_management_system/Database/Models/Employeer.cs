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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string PINcode { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Departament { get; set; }
        public string EmployeerCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
