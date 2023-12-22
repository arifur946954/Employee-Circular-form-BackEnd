using EfCoreRelation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//database connection SQL Server
builder.Services.AddDbContext<AppDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContractApiConnectionApi"));
});

//database connection Oracle
/*builder.Services.AddDbContext<AppDBContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("ContractApiConnectionApi"));
});*/




//database connection Inmemori
/*builder.Services.AddDbContext<ConnectionStrings>(options => options.UseInMemoryDatabase("ContractsDB"));*/






var app = builder.Build();








// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
