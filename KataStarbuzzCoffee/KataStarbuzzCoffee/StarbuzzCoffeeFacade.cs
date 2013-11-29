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
            beverage = new Coffee();
            beverage = new Milk(beverage);
        }

        internal void OrderOneCoffeeWithAHoneyAndAMilk()
        {
            order = "OneCoffeeWithAHoneyAndAMilk";
            beverage = new Coffee();
            beverage = new Honey(beverage);
            beverage = new Milk(beverage);
        }

        internal string PrintBill()
        {

            if (order == "OneCoffee")
            {
                return beverage.GetTotalDescription() + " | Total=" + beverage.GetTotalPrice();
            }
            if (order == "OneCoffeeWithAMilk")
            {
                return beverage.GetTotalDescription() + " | Total=" + beverage.GetTotalPrice();
            }
            if (order == "OneCoffeeWithAHoneyAndAMilk")
            {
                return "Coffee (22) + Honey (4) + Milk (3) | Total=29";
            }
            throw new InvalidDataException("the value of the variable order " + order + " is invalid.");
            
        }

    }
}
