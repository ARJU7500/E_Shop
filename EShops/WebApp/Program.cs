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
app.MapDefaultControllerRoute();
app.MapGet("/", () => "Hello World!");

app.Run();
