using API.Models;
using Microsoft.EntityFrameworkCore;
using Web.Middleware;
using WebApp.ApiService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession();
builder.Services.AddHttpClient("ApiServices", client =>
{

    client.BaseAddress = new Uri("https://localhost:7186/api/");
});


builder.Services.AddScoped<ApiService>();

// DbContext registration
builder.Services.AddDbContext<PRN221_Project_1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("value")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();
app.MapGet("/", () => Results.Redirect("/Homepage"));

app.UseMiddlewareFilter();

app.MapRazorPages();

app.Run();
