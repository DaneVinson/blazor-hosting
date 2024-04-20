namespace Domain;

public class PlanetHttpApi : IPlanetsApi
{
    private readonly HttpClient _httpClient;

    public PlanetHttpApi(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Planet> GetPlanetAsync(string name)
    {
        return await _httpClient.GetFromJsonAsync<Planet>($"planets/{name}") ?? default!;
    }

    public async Task<IEnumerable<Planet>> GetPlanetsAsync()
    {
        return await _httpClient.GetFromJsonAsync<Planet[]>("planets") ?? [];
    }
}
