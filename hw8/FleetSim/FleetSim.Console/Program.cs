using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Object;
using FleetSim.Object.Enum;
using FleetSim.Object.Interface;

namespace FleetSim.Console
{
    class Program
    {
        static void carVisit()// name given 
        {
            List<Car> paulaCars = new List<Car>()
            {
                new Car() { make = "Mercedes", model = "Benzo", mileage=0, lastServiceMileage=0},
                new Car() { make = "GMC", model = "Jimmy", year = 1998, mileage = 0, lastServiceMileage = 0 },
                new Car() { make = "Honda", model = "Civic", year = 1985, mileage = 0, lastServiceMileage = 0 },
                new Car() { make = "Ismael", model = "Nouvelle", year = 2007, mileage = 0, lastServiceMileage = 0 },
                new Car() { make = "Toyota", model = "Corola", year = 1889, mileage = 0, lastServiceMileage = 0 }
            };
            foreach (var car in paulaCars)
            {
                for (int counter = 0;  counter < 10; counter++)
                {
                    Random rnd = new Random();
                    int totalKilometrage = rnd.Next(5000, 15000);
                    car.mileage = car.mileage + totalKilometrage;
                    car.TuneUp(car.mileage, car.lastServiceMileage, car.lastServicedDate, car.model);

                };
            }
        }


        static void Main(string[] args)
        {
            try
            {
                carVisit();
            }
            catch(DllNotFoundException one)
            {
                System.Console.WriteLine("DllNotFoundException", one);
            }
            catch(EntryPointNotFoundException two)
            {
                System.Console.WriteLine("EntryPointNotFoundException", two);
            }
            catch(Exception ish)
            {
                System.Console.WriteLine("General exception caught", ish );
            }
        }
    }
}