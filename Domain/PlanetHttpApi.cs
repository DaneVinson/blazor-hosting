using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PlanetHttpApi : IPlanetsApi
    {
        private readonly HttpClient _httpClient;

        public PlanetHttpApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Planet> GetPlanetAsync(string name)
        {
            return await _httpClient.GetFromJsonAsync<Planet>($"planets/{name}");
        }

        public async Task<IEnumerable<Planet>> GetPlanetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Planet[]>("planets");
        }
    }
}
