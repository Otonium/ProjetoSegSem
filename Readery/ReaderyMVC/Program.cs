    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authentication.Google;
    using Microsoft.EntityFrameworkCore;   
    using Microsoft.EntityFrameworkCore;
    using Gardenia_MVC.Data;
    using Gardenia_MVC.Controllers;    
    using Gardenia_MVC.Data;    
    using Gardenia_MVC.Models;    
        
        
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(opcoes =>
{
    opcoes.IdleTimeout = TimeSpan.FromMinutes(30);
    opcoes.Cookie.HttpOnly = true;
    opcoes.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(opcoes =>
{
    opcoes.DefaultAuthenticateScheme = "Cookies";
    opcoes.DefaultChallengeScheme = "Google";
})
.AddCookie("Cookies")
.AddGoogle("Google", opcoes =>
{
    opcoes.ClientId = builder.Configuration["Google:ClientId"];
    opcoes.ClientSecret = builder.Configuration["Google:ClientSecret"];
});

builder.Services.AddDbContext<AppDbContext>(opcoes =>
    opcoes.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
