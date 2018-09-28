using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Object.Interface;
using FleetSim.Object.Enum;
namespace FleetSim.Object
{
    public class Car : Vehicle, ICar
    {
        private int _year;
        public int year { get; set; }

        private string _make;
        public string make { get; set; }

        private string _model;
        public string model
        { get; set; }


        
        public Car() { } 

        public Car(int year, string make, string model)
        {
            this._year = year;
            this._make = make;
            this._model = model;
        }

        public Car(int year, string make, string model, Colorvehicle myColor)
        {
            this._year = year;
            this._make = make;
            this._model = model;
            this.vehColor = myColor; 
        }

    }
}
