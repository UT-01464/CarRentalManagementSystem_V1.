namespace CarRentalManagementSystem_V1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("CAR_001", "TOYOTA", "prius", 10);
            Console.WriteLine(Car1);


            CarManager ObjCarManager = new CarManager();

            //ObjCarManager.CreateCar(new Car("100", "bmw", "Car", 200));
            //ObjCarManager.ReadCar();


            //Console.WriteLine("Car Id");
            //var Id = int.Parse(Console.ReadLine());


            //ObjCarManager.UpdateCar("200", "a", "A", 500);
            //ObjCarManager.ReadCar();


            //Console.WriteLine("CarId : ");
            //var Delete = Console.ReadLine();

            //ObjCarManager.DeleteCar(Delete);
            //ObjCarManager.ReadCar();



            Console.ReadLine();

            int Option;


            do
            {
                Console.WriteLine("Car Rental Management System: ");
                Console.WriteLine("1. Add a Car");
                Console.WriteLine("2. View All Cars");
                Console.WriteLine("3. Update a Car");
                Console.WriteLine("4. Delete a Car");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");


                if (!int.TryParse(Console.ReadLine(), out Option))
                {
                    Console.WriteLine("Please choice the correct Option");
                    continue;
                }

                switch(Option)
                {
                    case 1:
                        Console.WriteLine("Enter the Car ID : ");
                        string Carid = Console.ReadLine();

                        Console.WriteLine("Enter the BrandName : ");
                        string BrandName = Console.ReadLine();

                        Console.WriteLine("Enter the ModelName : ");
                        string ModelName = Console.ReadLine();

                        Console.WriteLine("Enter the RentalPrice: ");
                        decimal RentalPrice = decimal.Parse(Console.ReadLine());
                        ObjCarManager.ValidateCarRentalPrice(RentalPrice);

                        var NewCar = new Car(Carid, BrandName, ModelName, RentalPrice);
                        ObjCarManager.CreateCar(NewCar);
                        break;


                    case 2:
                        ObjCarManager.ReadCar();
                        break;

                    case 3:
                        //Console.WriteLine("Enter the Car ID : ");
                        //string updateid = Console.ReadLine();

                        //Console.WriteLine("Enter the BrandName : ");
                        //string updatebrand = Console.ReadLine();

                        //Console.WriteLine("Enter the ModelName : ");
                        //string updatemodel = Console.ReadLine();

                        //Console.WriteLine("Enter the RentalPrice: ");
                        //decimal updatePrice = decimal.Parse(Console.ReadLine());

                        //ObjCarManager.UpdateCar(updateid, updatebrand, updatemodel, updatePrice);
                        break;



                    case 4:
                        Console.WriteLine("Enter the deleted Car Id");
                        var DeleteId = Console.ReadLine();

                        ObjCarManager.DeleteCar(DeleteId);
                        break;

                    case 5:
                        Console.WriteLine("Exit..");
                         break;

                }








            }
            while (true);





        }
    }
}
