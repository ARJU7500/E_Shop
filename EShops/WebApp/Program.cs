using Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var con = builder.Configuration.GetConnectionString("Con");
builder.Services.AddDbContextPool<ShopContext>(
    opt=>opt.UseSqlServer(con));

var app = builder.Build();
app.UseStaticFiles();
app.MapAreaControllerRoute(
    name: "storearea",
    areaName: "StoreArea",
    pattern: "{area:exists}/{controller=StoreHome}/{action=Index}/{id?}"
);

app.MapDefaultControllerRoute();

app.Run();
