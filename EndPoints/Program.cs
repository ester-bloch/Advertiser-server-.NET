using Core.Mapping;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Core.Repository.Customers;
using Core.Repository.Orders;
using Core.Services.Customers;
using Services.Customers;
using Infrastructure.Customers;
using Infrastructure.OrderCustomers;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AdvertiserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdvertiserDb")));
// Services
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IContactCustomerService, ContactCustomerService>();
builder.Services.AddScoped<IOrderCustomerService, OrderCustomerService>();

// Repositories
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IContactCustomerRepository, ContactCustomerRepository>();
builder.Services.AddScoped<IOrderCustomerRepository, OrderCustomerRepository>();

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
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
