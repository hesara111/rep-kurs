using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirsZ1
{
    public class Truck : Car, ITruck
    {
        public int Capacity;
        public Truck(string model, int year, string colour, int cost, int capacity) : base(model, year, colour, cost)
        {
            Capacity = capacity;
        }
        public void GetCapacity()
        {
            Console.WriteLine($"Грузоподьемность {Model}: {Capacity} кг");
        }
    }
}
