namespace Domain;

public interface IPlanetsApi
{
    Task<Planet> GetPlanetAsync(string name);
    Task<IEnumerable<Planet>> GetPlanetsAsync();
}
