using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirsZ1
{
    public class LightCar : Car, ILightCar
    {
        public int NumberOfPassengers;

        public LightCar(string model, int year, string colour, int cost, int number) : base(model, year, colour, cost)
        {
            NumberOfPassengers = number;
        }
        public void GetNumberOfPassengers()
        {
            Console.WriteLine($"Количество пассажиров {Model}: {NumberOfPassengers}");
        }
    }
}
