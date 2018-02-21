using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakAndPlate.Model
{
    public class Car
    {
        public string Plate { get; set; }

        public Car() { }
        public Car(string _plate)
        {
            Plate = _plate;
        }

        
    }
}
