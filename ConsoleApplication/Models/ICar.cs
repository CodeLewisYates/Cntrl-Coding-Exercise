using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public interface ICar
    {
        Manufacturer Manufacturer { get; set; }
        public string Model { get; set; }
        int Horsepower { get; set; }
        TyreType TyreType { get; set; }
        EngineType EngineType { get; set; }
        double EngineSize { get; set; }
        int Weight { get; set; }
        Colours Colour { get; set; }
    }
}
