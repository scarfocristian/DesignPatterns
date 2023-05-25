namespace DesignPatterns.Estructural_Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public virtual string MakePizza()
        {
            return pizza.MakePizza();
        }
    }
}
