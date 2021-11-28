using CoffeeMachine.Domain;
using CoffeMachine.Common.Builders;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine.Tests.Logic
{
    [TestFixture]
    public class DrinkIngredientsTests
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new DrinkIngredients(null));
            //---------------Test Result -----------------------
        }

        [Test]
        public void DrinkIngredients_ShouldReturnCountOfOne_GivenIngredientsHasACountOfOne()
        {
            //---------------Set up test pack-------------------
            var ingredient = new CoffeBuilder().WithIngredientName("Coffee").Build();
            Ingredient[] ingredients = new Ingredient[] { ingredient };
            var sut = new DrinkIngredients(ingredients);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.Ingredients;
            //---------------Test Result -----------------------
            Assert.AreEqual(1, results.Count());
        }

        [Test]
        public void DrinkIngredients_ShouldReturnCountOfTwo_GivenIngredientsHasACountOfTwo()
        {
            //---------------Set up test pack-------------------
            var ingredient1 = new CoffeBuilder().WithIngredientName("Coffee").Build();
            var ingredient2 = new SugarBuilder().WithIngredientName("Suger").Build();
            Ingredient[] ingredients = new Ingredient[] { ingredient1, ingredient2 };
            var sut = new DrinkIngredients(ingredients);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.Ingredients;
            //---------------Test Result -----------------------
            Assert.AreEqual(2, results.Count());
        }

        [Test]
        public void DrinkIngredients_ShouldReturnCountOfThree_GivenMoreThenTwoIngredients()
        {
            //---------------Set up test pack-------------------
            var ingredient1 = new CoffeBuilder().WithIngredientName("Coffee").Build();
            var ingredient2 = new SugarBuilder().WithIngredientName("Sugar").Build();
            var ingredient3 = new MilkBuilder().WithIngredientName("Milk").Build();
            Ingredient[] ingredients = new Ingredient[] { ingredient1, ingredient2, ingredient3 };
            var sut = new DrinkIngredients(ingredients);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.Ingredients;
            //---------------Test Result -----------------------
            Assert.AreEqual(3, results.Count());
        }

        [TestCase("Ingredients", typeof(IEnumerable<Ingredient>))]
        public void DrinkIngredients_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(DrinkIngredients);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
