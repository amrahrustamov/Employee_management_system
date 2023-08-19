using Employee_management_system.Database.Models;
using Employee_management_system.Database.Repositories;
using Employee_management_system.Utilities;

namespace Employee_management_system.ViewModels
{
    public class ViewModel
    {
        public List<Employeers> employeer = new List<Employeers>();
        public EmployeerRepository employeerRepository;
        public StringUtility stringUtility = new StringUtility();
    }
}
