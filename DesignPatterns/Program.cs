using DesignPatterns.Builder;
using DesignPatterns.Estructural_Adapter;
using DesignPatterns.Estructural_Facade;
using DesignPatterns.FactoryMethodFirstExample;
using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creacional

            #region FactoryMethod
            //VehicleFactory factory = new ConcreteVehicleFactory();

            //IFactory scooter = factory.GetVehicle("Scooter");
            //scooter.Drive(10);
            //IFactory bike = factory.GetVehicle("Bike");
            //bike.Drive(20);
            #endregion

            #region Builder

            //var vehicleCreator = new VehicleCreator(new HeroBuilder());
            //vehicleCreator.CreateVehicle();
            //var vehicle = vehicleCreator.GetVehicle();
            //vehicle.ShowInfo();

            //Console.WriteLine("---------------------------------------------");

            //vehicleCreator = new VehicleCreator(new HondaBuilder());
            //vehicleCreator.CreateVehicle();
            //vehicle = vehicleCreator.GetVehicle();
            //vehicle.ShowInfo();


            #endregion

            #region Singleton

            //var singleton = SingletonInstance.GetInstance();

            #endregion

            #endregion

            #region Estructural

            #region Adapter

            //Adaptee adaptee = new Adaptee();
            //ITarget target = new Adapter(adaptee);

            //Console.WriteLine(target.GetRequest());

            #endregion

            #region Facade

            //Facade facade = new Facade();
            //facade.MethodA();
            //facade.MethodB();

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
