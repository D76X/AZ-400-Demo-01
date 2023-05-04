using BusinessLogic.Data;
using DataAccess.Data;
using DataAccess.DbAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//-------------------------------------------------------------------------------------

//https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studiohttps://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio

builder.Services.AddDbContext<MusicCatalogContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("MusicCatalogContext")));

// Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore 
// https://stackoverflow.com/questions/65007086/services-adddatabasedeveloperpageexceptionfilter-error-code-cs1061
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// https://learn.microsoft.com/en-us/aspnet/core/mvc/views/dependency-injection?view=aspnetcore-7.0
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<ICustomerData, CustomerData>();

//-------------------------------------------------------------------------------------
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
//-------------------------------------------------------------------------------------
//https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studiohttps://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio
//https://stackoverflow.com/questions/65389260/what-app-usemigrationsendpoint-does-in-net-core-web-application-startup-class
else
{
	app.UseDeveloperExceptionPage();

	// Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore 
	// https://stackoverflow.com/questions/65007086/services-adddatabasedeveloperpageexceptionfilter-error-code-cs1061
	app.UseMigrationsEndPoint();
}
//-------------------------------------------------------------------------------------

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
