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
    }
}
