using ExpenseTracker.Services.Application;
using ExpenseTracker.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]);
});

builder.Services.AddScoped<ExpenseService>();

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

app.Run();
