using User.Application.UseCases;
using User.Domain.Repositories;
using User.Infrostucture.Repositories;

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