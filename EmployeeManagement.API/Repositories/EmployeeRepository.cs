using EmployeeManagement.API.Data;
using EmployeeManagement.API.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagement.API.Repositories;
public class EmployeeRepository(AppDbContext db):IEmployeeRepository {
 public Task<List<Employee>> GetAllAsync()=>db.Employees.AsNoTracking().OrderBy(x=>x.Id).ToListAsync();
 public Task<Employee?> GetByIdAsync(int id)=>db.Employees.FirstOrDefaultAsync(x=>x.Id==id);
 public async Task<Employee> AddAsync(Employee e){db.Employees.Add(e);await db.SaveChangesAsync();return e;}
 public async Task UpdateAsync(Employee e){db.Employees.Update(e);await db.SaveChangesAsync();}
 public async Task DeleteAsync(Employee e){db.Employees.Remove(e);await db.SaveChangesAsync();}
}