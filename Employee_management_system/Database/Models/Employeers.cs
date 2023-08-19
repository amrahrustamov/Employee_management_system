namespace Employee_management_system.Database.Models
{
    public class Employeers
    {
        public Employeers(string name, string surname, string fatherName, string pINcode, string email, string photo, string departament, string employeerId)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            PINcode = pINcode;
            Email = email;
            Photo = photo;
            Departament = departament;
            EmployeerCode = employeerId;
        }

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
