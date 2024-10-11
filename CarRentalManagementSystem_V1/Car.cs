using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1_
{
    public class Car
    {
        internal string? carid;
        internal string model;
        internal string brand;
        internal decimal price;

        private string CarId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal rentalprice { get; set; }


        


        public Car(string carId, string brand, string model, decimal rentalprice)
        {
            CarId = carId;
            Brand = brand;
            Model = model;
            this.rentalprice = rentalprice;
        }


        public override string ToString()
        {
            return ($"ID: {CarId}, Brand: {Brand}, Model: {Model}, RentalPrice: {rentalprice}");
        }








    }



   
   
    

    




}
