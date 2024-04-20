using Domain;
using Services.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IPlanetsApi, PlanetsDataService>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

app.UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting()
    .UseAuthorization()
    .UseEndpoints(endpoints =>
    {
        endpoints.MapBlazorHub();
        endpoints.MapFallbackToPage("/_Host");
    });

app.Run();
