using Employee_management_system.Database.Models;
using Employee_management_system.ViewModels;

namespace Employee_management_system.Database.Repositories
{
    public class EmployeerRepository
    {
        public ViewModel viewModel = new ViewModel();

        private EmployeerDbContext _dbContext;

        public EmployeerRepository()
        {
            _dbContext = new EmployeerDbContext();
        }
        public List<Employeer> GetAll()
        {
            return _dbContext.Employeers.ToList();
        }
        public void Insert(Employeer employeer)
        {
            _dbContext.Employeers.Add(employeer);
            _dbContext.SaveChanges();
        }
    }
}
