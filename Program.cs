using CloudinaryDotNet;
using EmpregosOnLine.Data;
using EmpregosOnLine.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EmpregosOnLineDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<EnderecosService>();
builder.Services.AddScoped<EmpresasService>();
builder.Services.AddScoped<VagasService>();

// Cloudinary
var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

Account account = new Account(
    config["Cloudinary:CloudName"],
    config["Cloudinary:ApiKey"],
    config["Cloudinary:ApiSecret"]
);

Cloudinary cloudinary = new Cloudinary(account);
builder.Services.AddSingleton(cloudinary);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
