using Blazor.Core.Shared;
using Blazor.Wasm.Host;
using Domain;
using Services.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IPlanetsApi, PlanetsDataService>();
builder.Services
        .AddRazorComponents()
        .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

app.UseHsts()
    .UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting()
    .UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Blazor.Wasm.Client._Imports).Assembly, typeof(MainLayout).Assembly);

app.MapGet("/planets", async (IPlanetsApi planetsApi) =>
{
    return await planetsApi.GetPlanetsAsync();
});
app.MapGet("/planets/{name}", async (IPlanetsApi planetsApi, string name) =>
{
    return await planetsApi.GetPlanetAsync(name);
});

app.Run();
