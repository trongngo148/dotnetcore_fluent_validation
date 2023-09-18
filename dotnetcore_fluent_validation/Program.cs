using dotnetcore_fluent_validation.Models;
using dotnetcore_fluent_validation.ValidationExtensions;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvcCore();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IValidator<Product>, ProductValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<ProductValidator>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.MapControllers();

app.Run();

