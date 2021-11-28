using System;
using NUnit.Framework;
using CoffeeMachine.Domain;
using PeanutButter.TestUtils.Generic;
using CoffeeMachine.Tests.Builders;
using CoffeMachine.Common.Builders;

namespace CoffeeMachine.Tests.Domain
{
    [TestFixture]
    public class DisplayOrderTests
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new DisplayOrder(
                new DrinkBuilder()
                .WithRandomProps()
                .Build()));
            //---------------Test Result -----------------------
        }

        [Test]
        public void Construct_ShouldSetDrinkObject_GivenAValidObject()
        {
            //---------------Set up test pack-------------------
            var drink = new DrinkBuilder().WithRandomProps().Build();
            var displayOrder = new DisplayOrder(drink);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = displayOrder.Drink;
            //---------------Test Result -----------------------
            Assert.AreEqual(drink, results);
        }

        [Test]
        public void ToString_ShouldReturnAnIncompleteMessage_GivenNullIngredients()
        {
            //---------------Set up test pack-------------------
            var expected = "\nYou have ordered a ";
            var displayOrder = new DisplayOrder(null);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = displayOrder.ToString();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ToString_ShouldReturnACompleteMessage_GivenValidIngredients()
        {
            //---------------Set up test pack-------------------
            var ingredient = new CoffeBuilder().WithIngredientName("Coffee").Build();
            Ingredient[] ingredients = new Ingredient[] { ingredient };
            var drinkIngredients = new DrinkIngredientsBuilder().WithIngredients(ingredients).Build();
            var drink = new DrinkBuilder().WithIngredients(drinkIngredients);
            var expected = SetUpMessage(drink.Ingredients);
            var displayOrder = new DisplayOrder(drink.Build());
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = displayOrder.ToString();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("Drink", typeof(Drink))]
        public void DisplayOrder_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(DisplayOrder);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
        private static string SetUpMessage(DrinkIngredients ingredients)
        {
            var message = "";
            foreach (var ingredient in ingredients.Ingredients)
            {
                if (ingredient.IngredientName == "Coffee" ||
                    ingredient.IngredientName == "Cappuccino" ||
                    ingredient.IngredientName == "Latte")
                    message += ingredient.IngredientName + " With (" + ingredient.IngredientUnit + ") Beans,";
                else
                    message += " And (" + ingredient.IngredientUnit + ") Units of " + ingredient.IngredientName + ",";
            }
            message = message.TrimEnd(',');
            return $"\nYou have ordered a {message}"; ;
        }
    }
}