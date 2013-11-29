using NUnit.Framework;

namespace KataStarbuzzCoffee
{
    [TestFixture]
    public class KataStarbuzzCoffeeTest
    {
        private StarbuzzCoffeeFacade _starbuzzCoffeeFacade;

        [SetUp]
        protected void SetUp()
        {
            
        }

        [Test]
        public void TestOneCoffee()
        {
            // Given
            _starbuzzCoffeeFacade = new StarbuzzCoffeeFacade();
            // When
            _starbuzzCoffeeFacade.OrderOneCoffee();
            // Then
            Assert.AreEqual("Coffee (22) | Total=22", _starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22) | Total=22'.");
        }

        [Test]
        public void TestOneCoffeeWithAMilk()
        {
            // Given
            StarbuzzCoffeeFacade starbuzzCoffeeFacade = new StarbuzzCoffeeFacade();
            // When
            starbuzzCoffeeFacade.OrderOneCoffeeWithAMilk();
            // Then
            Assert.AreEqual("Coffee (22) + Milk (3) | Total=25", starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22) + Milk (3) | Total=25'.");
        }

        [Test]
        public void TestOneCoffeeWithAHoneyAndAMilk()
        {
            // Given
            StarbuzzCoffeeFacade starbuzzCoffeeFacade = new StarbuzzCoffeeFacade();
            // When
            starbuzzCoffeeFacade.OrderOneCoffeeWithAHoneyAndAMilk();
            // Then
            Assert.AreEqual("Coffee (22) + Honey (4) + Milk (3) | Total=29", starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22) + Honey (4) + Milk (3) | Total=29'");
        }
    }
}
