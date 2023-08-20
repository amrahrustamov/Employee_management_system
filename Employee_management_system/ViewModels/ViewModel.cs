using Employee_management_system.Database.Models;
using Employee_management_system.Database.Repositories;
using Employee_management_system.Utilities;

namespace Employee_management_system.ViewModels
{
    public class ViewModel
    {
        public List<Employeer> employeer = new List<Employeer>();
        public StringUtility stringUtility = new StringUtility();
    }
}
