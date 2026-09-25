using System.Net;
using System.Text.Json;
namespace EmployeeManagement.API.Middleware;
public class ExceptionMiddleware(RequestDelegate next,ILogger<ExceptionMiddleware> logger) {
 public async Task InvokeAsync(HttpContext context){try{await next(context);}catch(Exception ex){logger.LogError(ex,"Unhandled exception");context.Response.StatusCode=(int)HttpStatusCode.InternalServerError;context.Response.ContentType="application/json";await context.Response.WriteAsync(JsonSerializer.Serialize(new{message="An unexpected error occurred."}));}}
}