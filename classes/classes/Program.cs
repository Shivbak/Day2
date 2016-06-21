using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class car
    {
        public string make;
        public string model;
        public int price;

        public static int total_numberofcars;
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.make = "Reliant";
            car1.model = "abc";
            car1.price = 1000000000;

            car car2 = new car();
            car2.make = "BMW";
            car2.model = "XYZ";
            car2.price = 20000;

            car.total_numberofcars = 6;

            Console.WriteLine("Make {1} , model {0} , price {3:N0}, total cars {2}", car1.model,car1.make,car.total_numberofcars,car1.price);
        }
    }
}
