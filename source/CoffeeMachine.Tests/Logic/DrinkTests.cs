using CoffeeMachine.Domain;
using CoffeMachine.Common.Builders;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using System;

namespace CoffeeMachine.Tests.Logic
{
    [TestFixture]
    public class DrinkTests
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Drink("",new DrinkIngredients()));
            //---------------Test Result -----------------------
        }

        [Test]
        public void Construct_ShouldSetDrinkName()
        {
            //---------------Set up test pack-------------------
            var drinkName = "drink name";
            var sut = new Drink(drinkName, null);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.DrinkName;
            //---------------Test Result -----------------------
            Assert.AreEqual(drinkName, results);
        }

        [Test]
        public void Construct_ShouldSetIngredients()
        {
            //---------------Set up test pack-------------------
            var ingredient = new CoffeBuilder().WithIngredientName("Coffee").Build();
            Ingredient[] ingredients = new Ingredient[] { ingredient };
            var drinkIngredients = new DrinkIngredientsBuilder().WithIngredients(ingredients).Build();
            var sut = new Drink("", drinkIngredients);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.Ingredients;
            //---------------Test Result -----------------------
            Assert.AreEqual(drinkIngredients, results);
        }


        [TestCase("DrinkName", typeof(string))]
        [TestCase("Ingredients", typeof(DrinkIngredients))]
        public void Drink_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Drink);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
