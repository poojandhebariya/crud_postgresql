using crud_postgresql.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_postgresql.Services
{
    public interface IEmployeeService
    {
        Task<bool> CreateEmployee(Employee employee);
        Task<List<Employee>> GetEmployeeList();
        Task<Employee> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int key);
        Task<IActionResult> GetEmployee(int id);

    }
}
