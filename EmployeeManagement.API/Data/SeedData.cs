using EmployeeManagement.API.Models;
namespace EmployeeManagement.API.Data;
public static class SeedData {
 public static void Initialize(AppDbContext db) {
  if(db.Employees.Any()) return;
  db.Employees.AddRange(
   new Employee{FirstName="Anita",LastName="Rao",Email="anita.rao@example.com",Department="Engineering",Salary=95000,HireDate=new DateTime(2024,1,15)},
   new Employee{FirstName="David",LastName="Miller",Email="david.miller@example.com",Department="Finance",Salary=82000,HireDate=new DateTime(2023,6,1)});
  db.SaveChanges();
 }
}