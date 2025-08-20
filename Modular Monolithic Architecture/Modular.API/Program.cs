using OrderService.Repositories;
using OrderService.UseCases;
using UserService.Repositories;
using UserService.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddTransient<GetUsers>();
builder.Services.AddTransient<GetUserById>();
builder.Services.AddTransient<CreateUser>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<GetOrders>();
builder.Services.AddTransient<GetOrderById>();
builder.Services.AddTransient<CreateOrder>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(options => { options.EnableTryItOutByDefault(); });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();