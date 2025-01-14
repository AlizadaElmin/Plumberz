using Microsoft.EntityFrameworkCore;
using Plumberz.BL.Services.Abstracts;
using Plumberz.BL.Services.Implements;
using Plumberz.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddAutoMapper(typeof(PlumberzDbContext).Assembly);
builder.Services.AddDbContext<PlumberzDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSql"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
