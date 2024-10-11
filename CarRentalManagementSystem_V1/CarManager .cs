using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1_
{
    public class CarManager
    {

       List<Car> cars= new List<Car>();

      // Create Car 

        public void CreateCar(Car car)
        {  
            cars.Add(car);
            Console.WriteLine("Car Added Successfully");
        }

        // Read Car

        public void ReadCar()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("No avilable cars");
            }
            
                 
        }


    // Update Car

        //public void UpdateCar(string CarId,string Brand , string Model , decimal rentalprice)
        //{
        //    var findId = cars.Find(c => c.Carid == CarId);
        //}

        











    }




}
}
