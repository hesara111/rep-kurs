using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KirsZ1
{
    class Program
    {
        static void Main(string[] args)
        {

            LightCar l = new LightCar("Toyota Camry", 2013, "Black", 23000, 5);
            //   l.GetNumberOfPassengers();
            LightCar l1 = new LightCar("Toyota Camry", 2013, "White", 21000, 5);
            Truck h = new Truck("DAF 2103", 1999, "White", 17500, 21000);
            h.GetInfo();
            h.GetDiscount();

            h.GetCapacity();
        }
    }
}

