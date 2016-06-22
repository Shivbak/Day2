using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public static int TotalNoOfVehicle;

       public static void Total_Vehicle()
        {
            Console.WriteLine("Total No of Vehivle in Showroom : {0}",TotalNoOfVehicle);
        }
    }

    class Car : Vehicle
    {
        public string makecar;
        public string modelcar;
        public int pricecar;
        public Boolean soldcar;

        public void Addcar(string make,string model, int price)
        {
            this.makecar = make;
            this.modelcar = model;
            this.pricecar = price;
            TotalNoOfVehicle++;
            Vehicle.Total_Vehicle();
        }

        public void Soldcar(bool sold,int price)
        {
            this.soldcar = sold;
            this.pricecar = price;
            TotalNoOfVehicle--;
        }
    }

    class Bike : Vehicle
    {
        public string makebike;
        public string modelbike;
        public int pricebike;
        public Boolean soldbike;

        public void AddBike(string make, string model, int price)
        {
            this.makebike = make;
            this.modelbike = model;
            this.pricebike = price;
            TotalNoOfVehicle++;
        }

        public void SoldBike(bool sold, int price)
        {
            this.soldbike = sold;
            this.pricebike = price;
            TotalNoOfVehicle--;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Addcar("BMW", "ABC", 10000);

            Bike bike1 = new Bike();
            bike1.AddBike("ABC","XYZ",20000);
            Vehicle.Total_Vehicle();
        }
    }
}
