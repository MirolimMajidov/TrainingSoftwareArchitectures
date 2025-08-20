var builder = DistributedApplication.CreateBuilder(args);
var service1 = builder.AddProject<Projects.UserService>("user-service");
var service2 = builder.AddProject<Projects.OrderService>("order-service");

builder.Build().Run();