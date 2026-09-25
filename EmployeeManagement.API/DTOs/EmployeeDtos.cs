using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.API.DTOs;
public record EmployeeDto(int Id,string FirstName,string LastName,string Email,string Department,decimal Salary,DateTime HireDate);
public class CreateEmployeeDto {
 [Required,MaxLength(100)] public string FirstName {get;set;}="";
 [Required,MaxLength(100)] public string LastName {get;set;}="";
 [Required,EmailAddress] public string Email {get;set;}="";
 [Required] public string Department {get;set;}="";
 [Range(0,10000000)] public decimal Salary {get;set;}
 public DateTime HireDate {get;set;}=DateTime.UtcNow.Date;
}
public class UpdateEmployeeDto : CreateEmployeeDto {}