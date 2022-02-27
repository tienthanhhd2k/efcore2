using efcore2.Models;
using efcore2.Services;
using efcore2.Responsitory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDbContext>(
    options => options.UseSqlServer("Server=TIXNTHXNH;Initial Catalog=DBName;Integrated Security=True")
);
builder.Services.AddTransient<IProductResponsitory, ProductRespository>();
builder.Services.AddTransient<ICategoryResponsitory, CategoryResponsitory>();
builder.Services.AddTransient<IProduct, ProductServices>();
builder.Services.AddTransient<ICategory, CategoryServices>();

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
