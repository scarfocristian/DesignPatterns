namespace DesignPatterns.FactoryMethodFirstExample
{
    public interface VehicleFactory
    {
        public IFactory GetVehicle(string Vehicle);
    }
}
