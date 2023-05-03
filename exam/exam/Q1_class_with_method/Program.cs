using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_class_with_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("HONDA", "Honda_city", 2016, 25000.0f);
            Console.WriteLine("My Name is a " + myCar.Car_model + " That Model Of Year " +  myCar.purchase_Year  + " And the car Brand is" + myCar.Car_name + ".");
            Console.WriteLine("It had yeasterday miles " + myCar.total_Mileage.ToString("0.00") + " miles.");
            myCar.Drive(250.0f);
            
        }
        public class Car
        {
            // Properties
            public string Car_name { get; set; }
            public string Car_model { get; set; }
            public int purchase_Year { get; set; }
            public float total_Mileage { get; set; }

            // Constructor
            public Car(string car_name, string car_model, int purchaseyear, float totalmileage)
            {
                Car_name = car_name;
                Car_model = car_model;
                purchase_Year = purchaseyear;
                total_Mileage = totalmileage;
            }

            // Method
            public void Drive(float distance)
            {
                Console.WriteLine("Driving the car is " + distance + " miles...");
                total_Mileage += distance;
                Console.WriteLine("Current mileage of car is : " + total_Mileage.ToString("0.00"));
            }
        }

    }
}
