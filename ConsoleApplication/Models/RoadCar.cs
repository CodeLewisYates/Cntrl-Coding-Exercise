using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class RoadCar : Car, IRoadCar
    {
        public double AnnualTax { get; set; }
        public float InsuranceMultiplier { get; set; }
    }
}
