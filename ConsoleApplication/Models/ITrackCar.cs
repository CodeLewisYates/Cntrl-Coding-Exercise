using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public interface ITrackCar
    {
        public Tracks Track { get; set; }
        public TimeOnly BestLap { get; set; }
    }
}
