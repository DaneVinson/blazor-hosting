using Domain;
using Services.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IPlanetsApi, PlanetsDataService>();

var app = builder.Build();

app.UseHsts()
    .UseHttpsRedirection()
    .UseBlazorFrameworkFiles()
    .UseStaticFiles()
    .UseRouting()
    .UseEndpoints(builder => builder.MapFallbackToFile("index.html"));

app.MapGet("/planets", async (IPlanetsApi planetsApi) =>
{
    return await planetsApi.GetPlanetsAsync();
});
app.MapGet("/planets/{name}", async (IPlanetsApi planetsApi, string name) =>
{
    return await planetsApi.GetPlanetAsync(name);
});

app.Run();
