namespace CoffeeMachine.Domain
{
    public class DisplayOrder
    {
        public DisplayOrder(Drink drink)
        {
            Drink = drink;
        }

        public Drink Drink { get; set; }

        public override string ToString()
        {
            var ingredients = "";
            if (Drink?.Ingredients?.Ingredients != null)
            {
                foreach (var ingredient in Drink.Ingredients.Ingredients)
                {
                    if (ingredient.IngredientName == "Coffee" ||
                        ingredient.IngredientName == "Cappuccino" ||
                        ingredient.IngredientName == "Latte")
                        ingredients += ingredient.IngredientName + " With (" + ingredient.IngredientUnit + ") Beans,";
                    else
                        ingredients += " And (" + ingredient.IngredientUnit + ") Units of " + ingredient.IngredientName + ",";
                }
            }

            ingredients = ingredients.TrimEnd(',');
            return $"\nYou have ordered a {ingredients}";
        }
    }
}
