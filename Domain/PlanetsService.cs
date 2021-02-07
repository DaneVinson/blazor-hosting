using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Domain
{
    public class PlanetsService
    {
        private readonly Planet[] _planets;

        public PlanetsService()
        {
            string json;
            var assembly = Assembly.GetAssembly(typeof(Planet));
            var resourceStream = assembly.GetManifestResourceStream("Domain.planets.json");
            using (var reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                json = reader.ReadToEnd();
            }

            _planets = JsonSerializer.Deserialize<Planet[]>(json);
        }

        public IEnumerable<Planet> GetPlanets() => _planets;
    }
}
