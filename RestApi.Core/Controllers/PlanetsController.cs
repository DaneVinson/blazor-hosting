using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanetsController : ControllerBase, IPlanetsApi
    {
        private readonly PlanetsService _service;

        public PlanetsController(PlanetsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{name}")]
        public Task<Planet> GetPlanetAsync(string name)
        {
            return Task.FromResult(_service.GetPlanets().FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)));
        }

        [HttpGet]
        public Task<IEnumerable<Planet>> GetPlanetsAsync()
        {
            return Task.FromResult(_service.GetPlanets());
        }
    }
}
