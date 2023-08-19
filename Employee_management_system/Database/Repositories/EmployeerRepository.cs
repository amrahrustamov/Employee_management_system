using Employee_management_system.Database.Models;
using Employee_management_system.ViewModels;

namespace Employee_management_system.Database.Repositories
{
    public class EmployeerRepository
    {
        public ViewModel viewModel = new ViewModel();

        public EmployeerRepository()
        {

        }
        public List<Employeers> GetEmployeers()
        {
            return viewModel.employeer.ToList();
        }
        public void Insert(Employeers employeer)
        {
            viewModel.employeer.Add(employeer);
        }
    }
}
