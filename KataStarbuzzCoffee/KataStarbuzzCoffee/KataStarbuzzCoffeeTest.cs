using NUnit.Framework;

namespace KataStarbuzzCoffee
{
    [TestFixture]
    public class KataStarbuzzCoffeeTest
    {
        [Test]
        public void TestOneCoffee()
        {
            // Given
            StarbuzzCoffeeFacade starbuzzCoffeeFacade = new StarbuzzCoffeeFacade();
            // When
            starbuzzCoffeeFacade.OrderOneCoffee();
            // Then
            Assert.AreEqual("Coffee (22.00) | Total=22.00", starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22.00) | Total=22.00'.");
        }

        [Test]
        public void TestOneCoffeeWithAMilk()
        {
            // Given
            StarbuzzCoffeeFacade starbuzzCoffeeFacade = new StarbuzzCoffeeFacade();
            // When
            starbuzzCoffeeFacade.OrderOneCoffeeWithAMilk();
            // Then
            Assert.AreEqual("Coffee (22.00) + Milk (3.50) | Total=25.50", starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22.00) + Milk (3.50) | Total=25.50'.");
        }

        [Test]
        public void TestOneCoffeeWithAHoneyAndAMilk()
        {
            // Given
            StarbuzzCoffeeFacade starbuzzCoffeeFacade = new StarbuzzCoffeeFacade();
            // When
            starbuzzCoffeeFacade.OrderOneCoffeeWithAHoneyAndAMilk();
            // Then
            Assert.AreEqual("Coffee (22.00) + Honey (4.50) + Milk (3.50) | Total=30.00", starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22.00) + Honey (4.50) + Milk (3.50) | Total=30.00'");
        }
    }
}
