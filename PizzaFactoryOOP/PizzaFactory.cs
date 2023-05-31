using System.Collections.Generic;

namespace PizzaFactoryOOP
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(PizzaSize size, List<string> toppings)
        {
            return new Pizza(size, toppings);
        }
    }
}
