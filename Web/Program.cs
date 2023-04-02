using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Web.Interfaces;
using Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var cs = builder.Configuration.GetConnectionString("BaglantiCumlesi"); // appsettings.json dosyasýndaki Connection String cümlesini alýyoruz
builder.Services.AddDbContext<UygulamaDbContext>(o => o.UseSqlServer(cs));

builder.Services.AddScoped<IYazarlarViewModelService, YazarlarViewModelService>();

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
