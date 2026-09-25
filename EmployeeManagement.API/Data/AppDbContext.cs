using EmployeeManagement.API.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagement.API.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext(options) {
 public DbSet<Employee> Employees => Set<Employee>();
 protected override void OnModelCreating(ModelBuilder modelBuilder) {
  modelBuilder.Entity<Employee>().HasIndex(x=>x.Email).IsUnique();
  modelBuilder.Entity<Employee>().Property(x=>x.Salary).HasPrecision(18,2);
 }
}