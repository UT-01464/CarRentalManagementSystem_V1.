using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1_
{
    public class ElectricCar : Car
    {

        public int BatteryCapacity {  get; set; }
        public int MotorPower{ get; set; }  


        public ElectricCar(string carId, string brand, string model, decimal rentalprice) : base(carId, brand, model, rentalprice)
        {
            
        }
    }
}
