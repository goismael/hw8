using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Object
{
    interface IVehicles
    {
        void TuneUp(int mileage, int lastServiceMileage, DateTime lastServicedDate, string carModel);
        void RebuildEngine(string carModel);
    }
    
}
