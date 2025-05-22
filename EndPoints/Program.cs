using Core.Mapping;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Core.Repository.Customers;
using Core.Repository.Orders;
using Core.Services.Customers;
using Services.Customers;
using Infrastructure.Customers;
using Infrastructure.OrderCustomers;
using Core.Services.Orders;
using Services.Orders;
using Core.Repository;
using Infrastructure.Orders;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AdvertiserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdvertiserDb")));
//services
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IContactCustomerService, ContactCustomerService>();
builder.Services.AddScoped<IOrderCustomerService, OrderCustomerService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();

// Repositories
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IContactCustomerRepository, ContactCustomerRepository>();
builder.Services.AddScoped<IOrderCustomerRepository, OrderCustomerRepository>();
builder.Services.AddScoped<IOrderRepository, IOrderRepository>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();

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
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.MapGet("/", context =>
    {
        context.Response.Redirect("/swagger");
        return Task.CompletedTask;
    });
}

app.Run();
