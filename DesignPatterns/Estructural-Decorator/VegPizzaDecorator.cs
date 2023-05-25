namespace DesignPatterns.Estructural_Decorator
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(Pizza pizza) : base(pizza)
        {
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }
        private string AddVegetables()
        {
            return ", Vegetables added";
        }
    }
}
