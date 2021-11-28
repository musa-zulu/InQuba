using NUnit.Framework;
using CoffeeMachine.Domain;

namespace CoffeeMachine.Tests.Domain
{
    [TestFixture]
    public class MilkTests
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Milk(1));
            //---------------Test Result -----------------------
        }

        [Test]
        public void Construct_ShouldSetIngredientNameToMilk()
        {
            //---------------Set up test pack-------------------
            var sut = new Milk(1);
            var expected = "Milk";
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
            var sut = new Milk(ingredientsUnit);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.IngredientUnit;
            //---------------Test Result -----------------------
            Assert.AreEqual(ingredientsUnit, results);
        }
    }
}
