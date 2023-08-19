using Employee_management_system.Database.Repositories;
using Employee_management_system.ViewModels;

namespace Employee_management_system.Utilities
{
    public class StringUtility
    {
        public string GetEmployeeCode()
        {
            ViewModel viewModel = new ViewModel();

             Random random = new Random();
            while (true)
            {
                int randomCode = random.Next(10000, 99999);
                string randomCodes = randomCode.ToString();
                string employeerCode = string.Concat("E", randomCodes);

                try
                {
                    foreach (var code in viewModel.employeer)
                    {
                        if (code.EmployeerCode == employeerCode)
                        {
                            break;
                        }
                         return employeerCode;
                    }

                }
                finally
                {
                    
                }
                    return employeerCode;
            }
        }
    }
}
