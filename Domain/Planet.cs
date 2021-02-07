using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Planet
    {
        public decimal Diameter { get; set; }
        public decimal Gravity { get; set; }
        public string Image { get; set; }
        public decimal Mass { get; set; }
        public string Name { get; set; }
        public decimal OrbitDistance { get; set; }
        public decimal OrbitPeriod { get; set; }

        public override string ToString()
        {
            return string.Format(
                            "{0}, Orbit(Mkm): {1}, Diameter(km): {2}, Gravity(Earth): {3}, Mass(Earth): {4}, OrbitPeriod(day): {5}",
                            Name,
                            OrbitDistance,
                            Diameter,
                            Gravity,
                            Mass,
                            OrbitPeriod);
        }
    }
}
