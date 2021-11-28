using CoffeeMachine.Domain;
using PeanutButter.RandomGenerators;

namespace CoffeMachine.Common.Builders
{
    public class DrinkIngredientsBuilder : GenericBuilder<DrinkIngredientsBuilder, DrinkIngredients>
    {
        public DrinkIngredientsBuilder WithIngredients(Ingredient[] ingredients)
        {
            return WithProp(x => x.Ingredients = ingredients);
        }
    }
}
