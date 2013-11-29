using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KataStarbuzzCoffee
{
    class StarbuzzCoffeeFacade
    {
        private string order = "";
        private Beverage beverage = null;

        internal void OrderOneCoffee()
        {
            order = "OneCoffee";
            beverage = new Coffee();
        }

        internal void OrderOneCoffeeWithAMilk()
        {
            order = "OneCoffeeWithAMilk";
        }

        internal void OrderOneCoffeeWithAHoneyAndAMilk()
        {
            order = "OneCoffeeWithAHoneyAndAMilk";
        }

        internal string PrintBill()
        {

            if (order == "OneCoffee")
            {
                return beverage.GetTotalDescription() + " | " + beverage.GetTotalPrice();
            }
            if (order == "OneCoffeeWithAMilk")
            {
                return "Coffee (22.00) + Milk (3.50) | Total=25.50";
            }
            if (order == "OneCoffeeWithAHoneyAndAMilk")
            {
                return "Coffee (22.00) + Honey (4.50) + Milk (3.50) | Total=30.00";
            }
            throw new InvalidDataException("the value of the variable order " + order + " is invalid.");
            
        }

    }
}
