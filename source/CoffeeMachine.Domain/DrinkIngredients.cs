using System.Collections.Generic;

namespace CoffeeMachine.Domain
{
    public class DrinkIngredients
    {
        public DrinkIngredients(params Ingredient[] ingredients)
        {
            Ingredients = ingredients;
        }

        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
