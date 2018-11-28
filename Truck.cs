using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursZ2
{
     public class Truck : Car, ITruck
    {
        private static int count = 0;
        public int Capacity;
        public Truck(string model, int year, string colour, int cost, int capacity) : base(model, year, colour, cost)
        {
            count++;
            Capacity = capacity;
        }
        public void GetCapacity()
        {
            Console.WriteLine($"Грузоподьемность {Model}: {Capacity} кг");
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Модель грузовика:{Model} Год выпуска:{YearOfRelease.Year} Пробег:{this.GetMileage(Mileage)} Цвет:{Colour} Стоимoсть:{Cost} ");
        }
        public static int Count()
        {
            return count;
        }
    }
}
