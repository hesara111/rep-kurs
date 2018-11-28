using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursZ2
{
    public abstract  class Car
    {
        public string Model;
        public DateTime YearOfRelease;
        public string Colour;
        public int Cost;
        public int Mileage=0;
        readonly int discount = 10;
       
        public int GetMileage(int Mileage)
        {
            return Mileage;    
        }


        public Car()
        {
            Colour="Red";

        }
        public Car(string model, int year, int cost) : this()
        {
            Model = model;
            Cost = cost;
            this.YearOfRelease = this.YearOfRelease.AddYears(year-1);
        }
        public Car(string model, int year, string colour, int cost)
        {
            Model = model;
            this.YearOfRelease = this.YearOfRelease.AddYears(year-1);
            
            Colour = colour;
            Cost = cost;
        }
        public void GetDiscount(int mounth=1)
        {
            Console.WriteLine($"Стоимость {Model} без скидки:{Cost}");
          //  Console.WriteLine("Ведите карту постоянного клиента(6 цифр):");
          //  string a = Console.ReadLine();
            const int M = 12;

            int newdiscount = discount;
           // if (a[0] == '1' && a[1] == '1')
           // {
              //  Console.WriteLine("Введите текущий месяц:");
               // int mounth = Convert.ToInt32(Console.ReadLine());
                if (mounth != M)
                {
                    newdiscount = discount + (2 * mounth);
                }
                if (mounth == M)
                {
                    newdiscount = discount + (2 * 30);
                }
                Cost = (Cost / 100) * (100 - newdiscount);
                Console.WriteLine($"Стоимость {Model} со скидкой:{Cost}");
           // }
          //  else
           // {
            //    Console.WriteLine("Извините, вы не можете получить скидку по вашей карте");
            //}
        }
        public static bool operator >(Car c1,Car c2)
        {
            return c1.Cost > c2.Cost;
        }
        public static bool operator <(Car c1, Car c2)
        {
            return c1.Cost < c2.Cost;
        }
        public void GetAge()
        {
            Console.WriteLine($"Возраст авто:{ DateTime.Now.Year - this.YearOfRelease.Year} лет");
        }
        public override bool Equals(object obj)
        {
            Car car = (Car)obj;
            return (this.Model == car.Model && this.YearOfRelease == car.YearOfRelease);

        }
        public abstract void GetInfo();
    }

}
