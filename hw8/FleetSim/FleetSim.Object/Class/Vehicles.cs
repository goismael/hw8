using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Object.Enum;
using FleetSim.Object.Interface;

namespace FleetSim.Object
{
    public class Vehicle : IVehicles
    {
        private Guid _vin;

        public Guid vin
        {
            get { return _vin; }
            set { _vin = value; }
        }

        private int _mileage;

        public int mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        private DateTime _lastServicedDate;
        public DateTime lastServicedDate
        {
            get { return _lastServicedDate; }
            set { _lastServicedDate = value; }
        }
        private int _lastServiceMileage;
        public int lastServiceMileage
        {
            get { return _lastServiceMileage; }
            set { _lastServiceMileage = value; }
        }

        public Colorvehicle vehColor { get; set; }


        public void TuneUp(int mileage, int lastServiceMileage, DateTime lastServicedDate, string carModel)
        {
            if (mileage - lastServiceMileage >= 30000)
            {
                this._lastServiceMileage = mileage;
                this._lastServicedDate = DateTime.Now;
                Console.WriteLine($"Vehicle tuned up at { _lastServiceMileage} miles on { _lastServicedDate}");
            }
            if (mileage >= 100000)
            {
                RebuildEngine(carModel);
            }
        }
        public void RebuildEngine(string carModel)
        {
            mileage = 0;
            lastServiceMileage = 0;
            Console.WriteLine($"Engine rebuilt on  {_lastServicedDate} for {carModel}");
            Console.ReadLine();
        }
    }

}
