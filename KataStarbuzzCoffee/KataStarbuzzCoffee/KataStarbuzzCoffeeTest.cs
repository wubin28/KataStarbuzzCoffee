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
            // Given
            _starbuzzCoffeeFacade = new StarbuzzCoffeeFacade();
        }

        [Test]
        public void TestOneCoffee()
        {
            // When
            _starbuzzCoffeeFacade.OrderOneCoffee();
            // Then
            Assert.AreEqual("Coffee (22) | Total=22", _starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22) | Total=22'.");
        }

        [Test]
        public void TestOneCoffeeWithAMilk()
        {
            // When
            _starbuzzCoffeeFacade.OrderOneCoffeeWithAMilk();
            // Then
            Assert.AreEqual("Coffee (22) + Milk (3) | Total=25", _starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22) + Milk (3) | Total=25'.");
        }

        [Test]
        public void TestOneCoffeeWithAHoneyAndAMilk()
        {
            // When
            _starbuzzCoffeeFacade.OrderOneCoffeeWithAHoneyAndAMilk();
            // Then
            Assert.AreEqual("Coffee (22) + Honey (4) + Milk (3) | Total=29", _starbuzzCoffeeFacade.PrintBill(), "Failure - the bill should be printed as 'Coffee (22) + Honey (4) + Milk (3) | Total=29'");
        }
    }
}
