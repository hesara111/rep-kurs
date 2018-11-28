using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursZ2
{
    public class LightCar : Car, ILightCar
    {
        public int NumberOfPassengers;

        public LightCar(string model, int year, string colour, int cost, int number) : base(model, year, colour, cost)
        {
            this.NumberOfPassengers = number;
        }
        public LightCar(string model, int year, int cost, int number) : base(model, year, cost)
        {
            this.NumberOfPassengers = number;
        }
        public void GetNumberOfPassengers()
        {
            Console.WriteLine($"Количество пассажиров {Model}: {NumberOfPassengers}");
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Модель авто:{Model} Год выпуска:{YearOfRelease.Year} Пробег:{Mileage} Цвет:{Colour} Стоимoсть:{Cost} ");
        }

    }
}
