using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KursZ2
{
     class Program
     {
         static void Main(string[] args)
         {
            LightCar l = new LightCar("Toyota Camry", 2013, "Black", 23000, 5);
            l.GetInfo();
            LightCar l1 = new LightCar("Toyota Camry", 2015, 25000, 5);
            l1.GetInfo();
            Truck h = new Truck("DAF 2103", 1999, "White", 15500, 21000);
            h.GetInfo();
            Truck h1 = new Truck("DAF 2103", 1999, "White", 17500, 20000);
            Truck h2 = new Truck("DAF 2103", 1999, "White", 17500, 21000);
            h1.GetInfo();
            h2.GetInfo();
            h2.GetAge();
            h2.GetDiscount(mounth:3);
            bool a= h < h1;
            Console.WriteLine(a);
            //h.GetDiscount();
            Console.WriteLine($"Количество грузовиков: { Truck.Count()}");
         }
     }
    
}

