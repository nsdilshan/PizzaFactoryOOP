using System.Collections.Generic;

namespace PizzaFactoryOOP
{
    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }

    public class Pizza
    {
        public PizzaSize Size { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza(PizzaSize size, List<string> toppings)
        {
            Size = size;
            Toppings = toppings;
        }

        public decimal CalculateCost()
        {
            decimal baseCost = 0;
            switch (Size)
            {
                case PizzaSize.Small:
                    baseCost = 10;
                    break;
                case PizzaSize.Medium:
                    baseCost = 12;
                    break;
                case PizzaSize.Large:
                    baseCost = 14;
                    break;
            }
            return baseCost + (Toppings.Count * 2);
        }

        public string GetDescription()
        {
            string sizeStr = Size.ToString();
            string toppingsStr = string.Join(", ", Toppings);
            return $"{sizeStr} pizza with {toppingsStr} toppings";
        }
    }
}
