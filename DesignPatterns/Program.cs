﻿using DesignPatterns.Builder;
using DesignPatterns.Comportamiento_Strategy;
using DesignPatterns.Estructural_Adapter;
using DesignPatterns.Estructural_Decorator;
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

            #region Decorator

            PlainPizza plainPizzaObj = new PlainPizza();
            string plainPizza = plainPizzaObj.MakePizza();
            Console.WriteLine(plainPizza);
                        
            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);

            string chickenPizza = chickenPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");
            
            VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizzaObj);
            string vegPizza = vegPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");

            #endregion

            #region Facade

            //Facade facade = new Facade();
            //facade.MethodA();
            //facade.MethodB();

            #endregion

            #endregion

            #region Comportamiento

            #region Strategy

            //Context context;
            //context = new Context(new ConcreteStrategyA());
            //context.ContextInterface();
            //context = new Context(new ConcreteStrategyB());
            //context.ContextInterface();

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
