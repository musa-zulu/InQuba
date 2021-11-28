using System;
using CoffeeMachine.Domain;

namespace CoffeeMachine.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //var program = new();
            //program.Run();
            //use builders
            var x = new Service.CoffeeMachine();
            var drinks = new Drink[]
            {
                new Drink("Cappuccino", new DrinkIngredients(new Milk(2), new Sugar(1)))
            };


            foreach (var drink in drinks)
                Console.WriteLine(drink.DrinkName);
        }
    }
}
