using System;
using System.Collections.Generic;

namespace PizzaFactoryOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PizzaFactory pizzaFactory = new PizzaFactory();

            // Create pizzas
            Pizza pizza1 = pizzaFactory.CreatePizza(PizzaSize.Small, new List<string> { "Cheese", "Ham" });
            Pizza pizza2 = pizzaFactory.CreatePizza(PizzaSize.Medium, new List<string> { "Cheese", "Pepperoni" });
            Pizza pizza3 = pizzaFactory.CreatePizza(PizzaSize.Large, new List<string> { "Cheese", "Ham", "Pepperoni" });

            // Create pizza order
            PizzaOrder order = new PizzaOrder();
            order.AddPizza(pizza1);
            order.AddPizza(pizza2);
            order.AddPizza(pizza3);

            // Print order details
            order.PrintOrder();
            Console.ReadKey();
        }
    }
}