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
            beverage = new Coffee(22);
        }

        internal void OrderOneCoffeeWithAMilk()
        {
            order = "OneCoffeeWithAMilk";
            beverage = new Coffee(22);
            beverage = new Milk(beverage, 3);
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
                return beverage.GetTotalDescription() + " | Total=" + beverage.GetTotalPrice();
            }
            throw new InvalidDataException("the value of the variable order " + order + " is invalid.");
            
        }

    }
}
