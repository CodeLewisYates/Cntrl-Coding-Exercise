using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class Car : ICar
    {
        public Manufacturer Manufacturer { get; set; }
        public string Model { get; set; } = string.Empty;
        public int Horsepower { get; set; }
        public TyreType TyreType { get; set; }
        public EngineType EngineType { get; set; }
        public double EngineSize { get; set; }
        public int Weight { get; set; }
        public Colours Colour { get; set; }

    }
}