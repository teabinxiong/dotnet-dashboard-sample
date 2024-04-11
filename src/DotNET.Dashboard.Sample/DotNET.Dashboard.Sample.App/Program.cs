using DotNET.Dashboard.Sample.App.Data;
using DotNET.Dashboard.Sample.Infrastructure.DependencyInjections;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using DotNET.Dashboard.Sample.Core.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSyncfusionBlazor();
builder.Services.AddHandlers(builder.Configuration);
builder.Services.AddDatabase(builder.Configuration);

var app = builder.Build();


Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(app.Configuration.GetSection("Syncfusion_License").Value);

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
