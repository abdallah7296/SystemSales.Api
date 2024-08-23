using Microsoft.EntityFrameworkCore;
using SystemSales.Core;
using SystemSales.infrastructure;
using SystemSales.infrastructure.Context;
using SystemSales.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Connection to  SQL Server 
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection"));
});
#region Dendencey Injeaction
builder.Services.AddInfrastructureDependencies()
    .AddServiceDependencies().AddCoreDependencies();

#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
