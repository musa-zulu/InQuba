using System;
using NUnit.Framework;
using CoffeeMachine.Domain;
using PeanutButter.TestUtils.Generic;
using CoffeeMachine.Tests.Builders;

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
            Assert.AreEqual(drink,results);
        }

        [TestCase("Drink", typeof(Drink))]
        public void Customer_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(DisplayOrder);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }


        //test drinkname, customer name, etc
        //public void Customer_ShouldSetProperty()
        //{
        //    //---------------Set up test pack-------------------
        //    var sut = typeof(Customer);
        //    //---------------Assert Precondition----------------
        //    //---------------Execute Test ----------------------
        //    sut.ShouldHaveProperty(propertyName, propertyType);
        //    //---------------Test Result -----------------------
        //}
    }
}