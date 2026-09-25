using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories;
namespace EmployeeManagement.API.Services;
public class EmployeeService(IEmployeeRepository repo):IEmployeeService {
 static EmployeeDto Map(Employee e)=>new(e.Id,e.FirstName,e.LastName,e.Email,e.Department,e.Salary,e.HireDate);
 public async Task<IEnumerable<EmployeeDto>> GetAllAsync()=>(await repo.GetAllAsync()).Select(Map);
 public async Task<EmployeeDto?> GetByIdAsync(int id){var e=await repo.GetByIdAsync(id);return e is null?null:Map(e);}
 public async Task<EmployeeDto> CreateAsync(CreateEmployeeDto d){var e=new Employee{FirstName=d.FirstName,LastName=d.LastName,Email=d.Email,Department=d.Department,Salary=d.Salary,HireDate=d.HireDate};return Map(await repo.AddAsync(e));}
 public async Task<bool> UpdateAsync(int id,UpdateEmployeeDto d){var e=await repo.GetByIdAsync(id);if(e is null)return false;e.FirstName=d.FirstName;e.LastName=d.LastName;e.Email=d.Email;e.Department=d.Department;e.Salary=d.Salary;e.HireDate=d.HireDate;await repo.UpdateAsync(e);return true;}
 public async Task<bool> DeleteAsync(int id){var e=await repo.GetByIdAsync(id);if(e is null)return false;await repo.DeleteAsync(e);return true;}
}