using CoffeeMachine.Domain;
using NUnit.Framework;

namespace CoffeeMachine.Tests.Logic
{
    [TestFixture]
    public class CoffeeTests
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Coffee(1));
            //---------------Test Result -----------------------
        }

        [Test]
        public void Construct_ShouldSetIngredientNameToCoffee()
        {
            //---------------Set up test pack-------------------
            var sut = new Coffee(1);
            var expected = "Coffee";
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.IngredientName;
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Construct_ShouldSetIngredientUnitToOne()
        {
            //---------------Set up test pack-------------------
            var ingredientsUnit = 1;
            var sut = new Coffee(ingredientsUnit);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.IngredientUnit;
            //---------------Test Result -----------------------
            Assert.AreEqual(ingredientsUnit, results);
        }
    }
}
