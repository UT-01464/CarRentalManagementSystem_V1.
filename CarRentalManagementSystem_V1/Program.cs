namespace CarRentalManagementSystem_V1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("CAR_001", "TOYOTA", "prius", 10);
            Console.WriteLine(Car1);


            CarManager ObjCarManager = new CarManager();

            ObjCarManager.CreateCar(new Car("100", "bmw", "Car", 200));
            ObjCarManager.ReadCar();


            Console.WriteLine("Car Id");
            var Id = int.Parse(Console.ReadLine());


            ObjCarManager.UpdateCar("200", "a", "A", 500);
            ObjCarManager.ReadCar();


            Console.WriteLine("CarId : ");
            var Delete = Console.ReadLine();

            ObjCarManager.DeleteCar(Delete);
            ObjCarManager.ReadCar();
           


            Console.ReadLine();




            //do
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //}
            //while (true);





        }
    }
}
