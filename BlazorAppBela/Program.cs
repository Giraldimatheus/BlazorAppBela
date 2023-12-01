using BlazorAppBela.Data;
using BlazorAppBela.Interfaces;
using BlazorAppBela.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorAppBela
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();

            builder.Services.AddHttpClient<IClienteAppService, ClienteAppService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44340/");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            builder.Services.AddHttpClient<IContatoAppService, ContatoAppService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44340/");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            var app = builder.Build();

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
        }
    }
}