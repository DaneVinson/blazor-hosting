namespace Services.Core;

public class PlanetsDataService : IPlanetsApi
{
    private readonly Planet[] _planets;

    public PlanetsDataService()
    {
        string json;
        var assembly = Assembly.GetAssembly(this.GetType())!;
        var resourceStream = assembly.GetManifestResourceStream("Services.Core.planets.json");
        using (var reader = new StreamReader(resourceStream!, Encoding.UTF8))
        {
            json = reader.ReadToEnd();
        }

        _planets = JsonSerializer.Deserialize<Planet[]>(json) ?? [];
    }

    public Task<Planet> GetPlanetAsync(string name)
    {
        var planet = _planets.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        return planet != null
                    ? Task.FromResult(planet!)
                    : throw new Exception($"{name} is not a known planet");
    }

    public Task<IEnumerable<Planet>> GetPlanetsAsync()
    {
        return Task.FromResult(_planets.AsEnumerable());
    }
}
