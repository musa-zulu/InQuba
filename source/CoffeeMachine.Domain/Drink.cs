namespace CoffeeMachine.Domain
{
    public class Drink
    {
        public Drink(string drinkName, DrinkIngredients ingredients)
        {
            Ingredients = ingredients;
            DrinkName = drinkName;
        }

        public string DrinkName { get; set; }
        public DrinkIngredients Ingredients { get; set; }
    }
}
