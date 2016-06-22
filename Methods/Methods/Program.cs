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
            //this.make = make;
            this.sold = sold;
            //this.price = price;
            total_numbercars--;
        }

        public static  void Listofcars(List<car> listofcars)
        {
            Console.WriteLine("in the list cars method");

           foreach(car item in listofcars)
            {
                Console.WriteLine(item.model + " "+ item.make + " " + item.price);
            }
           
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<car> myCarList = new List<car>();

            car car1 = new car();
            
            car1.AddCar("BMW", "ABC", 10000);
            myCarList.Add(car1);
            car.total_numbercars++;
            Console.WriteLine("make :{0} , total cars : {1}",car1.model, car.total_numbercars);

            car car2 = new car();
            car2.AddCar("Audi", "R9", 100000);
            
            myCarList.Add(car2);
            car.total_numbercars++;
            //Console.WriteLine("sold : {0} , price : {1} , total cars: {2}",car2.sold,car2.price,car.total_numbercars);

            car2.SoldCar(true, 30000);

            car.Listofcars(myCarList);
        }
    }
}
