using EasyCommerceShop.Infrastructure.Data.Validator;
using EasyCommerceShop.Infrastructure.Data;
using FluentValidation.AspNetCore;
using EasyCommerceShop.Application;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddDbContext<EasyShopDbContext>();
services.AddControllersWithViews()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ProductVadilator>());
services.AddApplication();


var app = builder.Build();

app.UseExceptionHandler("/Home/Error");
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
