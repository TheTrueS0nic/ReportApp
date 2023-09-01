﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReportApp.Data;
using ReportApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ReportAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ReportAppContext") ?? throw new InvalidOperationException("Connection string 'ReportAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedMemberData.Initialize(services);
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedReportData.Initialize(services);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
