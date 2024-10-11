using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1_
{
    public class PetrolCar : Car
    {

        public int FuelTankCapacity {  get; set; }
        public int EngineCapacity {  get; set; }



        public PetrolCar(string carId, string brand, string model, decimal rentalprice) : base(carId, brand, model, rentalprice)
        {
        }
    }
}
