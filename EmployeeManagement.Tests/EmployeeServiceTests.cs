using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories;
using EmployeeManagement.API.Services;
using Moq;
namespace EmployeeManagement.Tests;
public class EmployeeServiceTests {
 [Fact] public async Task GetById_ReturnsEmployee_WhenFound(){var repo=new Mock<IEmployeeRepository>();repo.Setup(r=>r.GetByIdAsync(1)).ReturnsAsync(new Employee{Id=1,FirstName="Test",LastName="User",Email="test@example.com",Department="IT",Salary=70000,HireDate=DateTime.Today});var service=new EmployeeService(repo.Object);var result=await service.GetByIdAsync(1);Assert.NotNull(result);Assert.Equal("Test",result!.FirstName);}
}