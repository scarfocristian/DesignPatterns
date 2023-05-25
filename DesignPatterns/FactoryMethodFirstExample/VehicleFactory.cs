namespace DesignPatterns.FactoryMethodFirstExample
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
}
