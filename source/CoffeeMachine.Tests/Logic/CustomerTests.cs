using System;
using NUnit.Framework;
using CoffeeMachine.Domain;
using PeanutButter.TestUtils.Generic;
using CoffeeMachine.Tests.Builders;

namespace CoffeeMachine.Tests.Domain
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Customer(string.Empty,
                new DrinkBuilder()
                .WithRandomProps()
                .Build()));
            //---------------Test Result -----------------------
        }

        [TestCase("Drink", typeof(Drink))]
        [TestCase("CustomerName", typeof(string))]
        public void Customer_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Customer);
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