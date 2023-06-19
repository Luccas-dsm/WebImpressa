
using Impressa.Shared.Models;

namespace Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployees();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        Task<Employee> GetEmployeeData(string id);
        void DeleteEmployee(string id);
        Task<List<Cities>> GetCityData();

    }
}
