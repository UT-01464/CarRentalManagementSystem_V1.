using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1_
{
    public class CarManager
    {

       List<Car> carlist= new List<Car>();

        public string carid { get; private set; }

        private string Brand;
        private string Model;
        private decimal rentalPrice;


        // Create Car 

        public void CreateCar(Car car)
        {
            carlist.Add(car);
            Console.WriteLine("Car Added Successfully");
        }

        // Read Car

        public void ReadCar()
        {
            if (carlist.Count == 0)
            {
                Console.WriteLine("No avilable cars");
            }
            foreach (Car car in carlist)
            {
                Console.WriteLine(car);
            }

                           
        }

        //public void UpdateCar(string newcarid, string newBrand, string newModel, decimal newrentalPrice)
        //{
        //    UpdateCar(newcarid, newBrand, newModel, newrentalPrice);
        //}


        //update car
        public void UpdateCar(string newcarid, string newBrand, string newModel, decimal newrentalPrice, Car car)
        {
           

            var FindId = carlist.Find(c => c.carid == newcarid);
            if (FindId != null)
            {
                car.carid = FindId.carid;
                car.model = newModel;
                car.brand = newBrand;
                car.price = newrentalPrice;

            }
            Console.WriteLine("Car not found");


        }









        // delete car

        public void DeleteCar(string carId)
        {
            string carid = null;
            var Deleteid = carlist.Find(c => c.carid == carid);

            if (Deleteid != null)
            {
                carlist.Remove(Deleteid);
                Console.WriteLine("Car Deleted SuccessFully");
            }
            Console.WriteLine("Car Not Found");


        }



        //	ValidateCarRentalPrice  

        //public decimal ValidateCarRentalPrice(decimal price)
        //{
        //    do
        //    {
        //        if (price <= 0)
        //        {
        //            Console.WriteLine("Price most be Positive");
        //        }
        //    }
        //    while (price <= 0);

        //    return price;

        //}


        //public decimal ValidateCarRentalPrice()
        //{
        //    decimal price;

        //        if (price <= 0)
        //        {
        //            do
        //            {
        //                Console.WriteLine("input the value again");
        //            }
        //            while (price <= 0);

        //        }
           
        //    return price;

        //}





















    }




}

