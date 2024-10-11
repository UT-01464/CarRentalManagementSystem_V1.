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


        //update car
        public void UpdateCar(string newcarid , string newBrand , string newModel , decimal newrentalPrice)
        {
            var FindId = carlist.Find(c=>c.carid==newcarid);
            if (FindId != null)
            {
                carid = FindId.carid;
                Brand = newBrand;
                Model = newModel;
                rentalPrice = newrentalPrice;
            }
            Console.WriteLine("Car not found");
              

        }


        // delete car

        public void DeleteCar(string carId)
        {
            string carid = null;
            var Deleteid =carlist.Find(c=>c.carid==carid);

            if (Deleteid != null)
            {
                carlist.Remove(Deleteid);
                Console.WriteLine("Car Deleted SuccessFully");
            }
            Console.WriteLine("Car Not Found");


        }






  

       

        











    }




}

