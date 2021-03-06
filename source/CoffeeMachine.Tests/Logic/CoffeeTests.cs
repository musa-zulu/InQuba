using CoffeeMachine.Domain;
using CoffeMachine.Common.Builders;
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
            var ingredientName = "Coffee";
            var sut = new CoffeBuilder()
                .WithIngredientName(ingredientName)
                .Build();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.IngredientName;
            //---------------Test Result -----------------------
            Assert.AreEqual(ingredientName, results);
        }

        [Test]
        public void Construct_ShouldSetIngredientUnitToOne()
        {
            //---------------Set up test pack-------------------
            var ingredientsUnit = 2;
            var sut = new CoffeBuilder()
                        .WithIngredientUnit(ingredientsUnit)
                        .Build();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.IngredientUnit;
            //---------------Test Result -----------------------
            Assert.AreEqual(ingredientsUnit, results);
        }
    }
}
