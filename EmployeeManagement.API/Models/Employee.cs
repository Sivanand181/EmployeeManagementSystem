using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.API.Models;
public class Employee {
 public int Id {get;set;}
 [Required,MaxLength(100)] public string FirstName {get;set;}="";
 [Required,MaxLength(100)] public string LastName {get;set;}="";
 [Required,EmailAddress,MaxLength(200)] public string Email {get;set;}="";
 [Required,MaxLength(100)] public string Department {get;set;}="";
 [Range(0,10000000)] public decimal Salary {get;set;}
 public DateTime HireDate {get;set;}
}