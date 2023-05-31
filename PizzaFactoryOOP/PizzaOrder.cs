using System;
using System.Collections.Generic;

namespace PizzaFactoryOOP
{
    public class PizzaOrder
    {
        private List<Pizza> pizzas;

        public PizzaOrder()
        {
            pizzas = new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var pizza in pizzas)
            {
                totalCost += pizza.CalculateCost();
            }
            return totalCost;
        }

        public void PrintOrder()
        {
            Console.WriteLine("Order Details:");
            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza.GetDescription());
            }
            decimal totalCost = CalculateTotalCost();
            Console.WriteLine($"Total Cost: ${totalCost}");
        }
    }
}
