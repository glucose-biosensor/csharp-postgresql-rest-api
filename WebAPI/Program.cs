using Microsoft.EntityFrameworkCore;
using WebAPI.Services;
using WebAPI.Services.Impl;
using WebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")!)
);
builder.Services.AddScoped<ISensorDataService, SensorDataService>();
builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IWavelengthService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
