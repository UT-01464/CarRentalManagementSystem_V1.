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

        public void UpdateCar(string carid , string Brand , string Model , decimal rentalPrice)
        {
            

           



        }

        public void DeleteCar(string carId)
        {

        }






  

       

        











    }




}

