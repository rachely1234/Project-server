using Microsoft.EntityFrameworkCore;
using Models.Model;
using Webapi.Controllers;
using AutoMapper;
using DAL.Interface;
using DAL.Dtos;
using DAL.Data;


string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
// string myCors = "_myCors";


// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(op =>
{
    op.AddPolicy(MyAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<ProjectCotext>(op => op.UseSqlServer("Data Source=DESKTOP-SI8MC0H;Initial Catalog=projectData;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;"));
//builder.Services.AddScoped<IPhoto, PhotoData>();
builder.Services.AddScoped<ITodo, TodoData>();
//builder.Services.AddScoped<IUser,UserData>();
builder.Services.AddScoped<IPost,PostData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();

