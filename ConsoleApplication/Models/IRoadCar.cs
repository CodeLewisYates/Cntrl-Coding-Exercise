using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public interface IRoadCar
    {
        public double AnnualTax { get; set; }
        public float InsuranceMultiplier { get; set; }
    }
}
