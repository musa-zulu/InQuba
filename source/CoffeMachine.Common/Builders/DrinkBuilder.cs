using CoffeeMachine.Domain;
using PeanutButter.RandomGenerators;

namespace CoffeeMachine.Tests.Builders
{
    public class DrinkBuilder : GenericBuilder<DrinkBuilder, Drink>
    {
        public DrinkBuilder()
        {
        }

        public string DrinkName { get; private set; }
        public DrinkIngredients Ingredients { get; private set; }

        public DrinkBuilder WithDrinkName(string drinkName)
        {
            DrinkName = drinkName;
            return this;
        }

        public DrinkBuilder WithIngredients(DrinkIngredients ingredients)
        {
            Ingredients = ingredients;
            return this;
        }

        public new Drink Build()
        {
            return new Drink(DrinkName, Ingredients);
        }
    }
}
