using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IPlanetsApi
    {
        Task<Planet> GetPlanetAsync(string name);
        Task<IEnumerable<Planet>> GetPlanetsAsync();
    }
}
