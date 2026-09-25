using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Services;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeManagement.API.Controllers;
[ApiController][Route("api/[controller]")]
public class EmployeesController(IEmployeeService service):ControllerBase {
 [HttpGet] public async Task<ActionResult> GetAll()=>Ok(await service.GetAllAsync());
 [HttpGet("{id:int}")] public async Task<ActionResult> Get(int id){var e=await service.GetByIdAsync(id);return e is null?NotFound():Ok(e);}
 [HttpPost] public async Task<ActionResult> Create(CreateEmployeeDto dto){var e=await service.CreateAsync(dto);return CreatedAtAction(nameof(Get),new{id=e.Id},e);}
 [HttpPut("{id:int}")] public async Task<ActionResult> Update(int id,UpdateEmployeeDto dto)=>await service.UpdateAsync(id,dto)?NoContent():NotFound();
 [HttpDelete("{id:int}")] public async Task<ActionResult> Delete(int id)=>await service.DeleteAsync(id)?NoContent():NotFound();
}