using EmployeeManagement.API.Data;
using EmployeeManagement.API.Repositories;
using EmployeeManagement.API.Services;
using EmployeeManagement.API.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
var app = builder.Build();
using (var scope = app.Services.CreateScope()) { var db = scope.ServiceProvider.GetRequiredService<AppDbContext>(); db.Database.EnsureCreated(); SeedData.Initialize(db); }
app.UseMiddleware<ExceptionMiddleware>();
app.UseSwagger(); app.UseSwaggerUI(); app.UseHttpsRedirection(); app.UseDefaultFiles();
app.UseStaticFiles(); app.MapControllers(); app.Run();
public partial class Program { }
