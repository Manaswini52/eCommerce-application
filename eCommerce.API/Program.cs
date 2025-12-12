using eCommerce.API.Middleware;
using eCommerce.Core;
using eCommerce.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

//Add Infrastructure services
builder.Services.AddInfrastructure();

//Add Core services
builder.Services.AddCore();

//Add controllers to service collection
builder.Services.AddControllers();

//build the web app
var app = builder.Build();

//Add Exception Handling
app.UseExceptionHandlingMiddleware();

//Routing
app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

//enable routing for controllers
app.MapControllers();
app.Run();
