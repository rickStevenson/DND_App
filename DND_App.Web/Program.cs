using Bloggie.Web.Repositories;
using DND_App.Web.Data;
using DND_App.Web.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DnDDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString
("DND_DbConnection")));

builder.Services.AddDbContext<UserDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString
("DND_UserAuth_DbConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.ClaimsIdentity.RoleClaimType = ClaimTypes.Role; // Add RoleClaimType for proper role functionality
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
})
.AddEntityFrameworkStores<UserDbContext>() // Ensure UserDbContext is used for identity
.AddDefaultTokenProviders();

builder.Services.AddScoped<ICharacterClassRepository, CharacterClassRepository>();
builder.Services.AddScoped<ICharacterRaceRepository, CharacterRaceRepository>();
builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IImageRepository, CloudinaryImageRepository>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
