using CoffeeMachine.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Tests.Logic
{
    [TestFixture]
    public class CappuccinoTests
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Cappuccino(1));
            //---------------Test Result -----------------------
        }

        [Test]
        public void Construct_ShouldSetIngredientNameToMilk()
        {
            //---------------Set up test pack-------------------
            var sut = new Cappuccino(1);
            var expected = "Cappuccino";
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
            var sut = new Cappuccino(ingredientsUnit);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = sut.IngredientUnit;
            //---------------Test Result -----------------------
            Assert.AreEqual(ingredientsUnit, results);
        }
    }
}
