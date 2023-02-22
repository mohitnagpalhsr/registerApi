using Microsoft.EntityFrameworkCore;
// using RepoLayer;
// using ServiceLayer;
// // using Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// builder.Services.AddDbContext<SportsEventManagementContext>(options =>
//     options.UseSqlServer(connectionString));

// builder.Services.AddTransient<ILoginModelRepo<LoginModel>, LoginModelRepo>();
// builder.Services.AddTransient<ILoginModelService<LoginModel>, LoginModelService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("EnableCORS", builder => 
    { 
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod(); 
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("EnableCORS");

app.UseAuthorization();

app.MapControllers();

app.Run();