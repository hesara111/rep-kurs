using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirsZ1
{
    public class Car
    {
        public string Model;
        public int YearOfRelease;
        public string Colour;
        public int Cost;

        public Car(string model, int year, string colour, int cost)
        {
            Model = model;
            YearOfRelease = year;
            Colour = colour;
            Cost = cost;
        }

        public void GetDiscount()
        {
            Console.WriteLine($"Стоимость {Model} без скидки:{Cost}");
            Console.WriteLine("Ведите карту постоянного клиента(6 цифр):");
            string a = Console.ReadLine();
            int discount = 100;
            if (a[0] == '1' && a[1] == '1')
            {
                discount = 20;
            }
            if (a[0] == '2' && a[1] == '2')
            {
                discount = 10;
            }
            Cost = (Cost / 100) * (100 - discount);
            Console.WriteLine($"Стоимость {Model} со скидкой:{Cost}");
        }
        public override bool Equals(object obj)
        {
            Car car = (Car)obj;
            return (this.Model == car.Model && this.YearOfRelease == car.YearOfRelease);

        }
        public void GetInfo()
        {
            Console.WriteLine($"Модель:{Model} Год выпуска:{YearOfRelease} Цвет:{Colour} Стоимсоть:{Cost} ");
        }
    }
}
