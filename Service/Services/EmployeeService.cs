
using DataAccess.DomainService;
using Impressa.Shared.Models;
using Service.Interfaces;

namespace Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeDataAccess _employeeService = new EmployeeDataAccess();
        public void AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
        }

        public void DeleteEmployee(string id)
        {
            _employeeService.DeleteEmployee(id);
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
    
       

            return await _employeeService.GetAllEmployees();
        }

        public async Task<List<Cities>> GetCityData()
        {
            return await GetCityData();
        }

        public async Task<Employee> GetEmployeeData(string id)
        {
            return await _employeeService.GetEmployeeData(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
        }
    }
}
