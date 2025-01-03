using Microsoft.EntityFrameworkCore;
using Labels_KM49.Data;
using Labels_KM49.Models;

var builder = WebApplication.CreateBuilder(args);
var oracleConnectionString = builder.Configuration.GetConnectionString("JitProdDBConnection") ?? throw new InvalidOperationException("Connection string 'JitProdDBConnection' not found.");
var sqlServerConnectionString = builder.Configuration.GetConnectionString("PilotosConnection") ?? throw new InvalidOperationException("Connection string 'PilotosConnection' not found.");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ModelContext>(options => 
{ 
    options.UseOracle(oracleConnectionString); 
});

builder.Services.AddDbContext<PilotosContext>(options =>
{
    options.UseSqlServer(sqlServerConnectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //    app.UseExceptionHandler("/Home/Error");
    //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //    app.UseHsts();
}
else
{
    //app.UseDeveloperExceptionPage();
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
    pattern: "{controller=Pilotos}/{action=Index}/{id?}");

app.Run();
