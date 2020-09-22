using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    interface IRunable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class FlyingBike : IFlyable, IRunable
    {
        public void Fly()
        {
            Console.WriteLine("Bike Fly");
        }
        public void Run()
        {
            Console.WriteLine("Bike Run");
        }
    }
    class FlyingCar : IFlyable, IRunable
    {
        public void Fly()
        {
            Console.WriteLine("Car Fly");
        }
        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }
    class Class4
    {
        static void Main()
        {
            FlyingCar car = new FlyingCar();
            car.Fly();
            car.Run();
            Flying(car);
            Running(car);

            FlyingBike bike = new FlyingBike();
            bike.Fly();
            bike.Run();
            Flying(bike);
            Running(bike);
        }
        static void Flying(IFlyable flyer)
        {
            flyer.Fly();
        }
        static void Running(IRunable runner)
        {
            runner.Run();
        }
        //static void Flying(FlyingCar car)
        //{
        //    car.Fly();
        //}
        //static void Flying(FlyingBike bike)
        //{
        //    bike.Fly();
        //}
    }
}
