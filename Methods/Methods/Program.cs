using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class car
    {
        public string make;
        public string model;
        public int price;
        public Boolean sold;

        public static int total_numbercars;

        public void AddCar(string make,string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
        }

        public void SoldCar(bool sold,int price)
        {
            total_numbercars--;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.AddCar("BMW", "ABC", 10000);
            car.total_numbercars = 10;
            Console.WriteLine("make :{0} , total cars : {1}",car1.model,car.total_numbercars);
            //car1.SoldCar()
        }
    }
}
