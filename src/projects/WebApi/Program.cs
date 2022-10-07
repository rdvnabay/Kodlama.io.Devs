using Application;
using Core.CrossCuttingConcers.Extensions;
using Persistence;
using WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen(options =>
{
    options.OrderActionsBy((apiDesc) => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.HttpMethod}");
});

builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
builder.Services.AddJwtBearer(builder.Configuration);
builder.Services.AddSwaggerSecurityScheme();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ConfigureCustomExceptionMiddleware();
}
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();


