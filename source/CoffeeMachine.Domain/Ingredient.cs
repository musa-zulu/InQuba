namespace CoffeeMachine.Domain
{
    /// <summary>
    /// Dependency Invesion Principle,
    /// Depend on abstraction, not on concretions.
    /// This Ingredient object is abstration layer
    /// </summary>
    public abstract class Ingredient
    {
        protected Ingredient(string ingredientName, int ingredientUnit)
        {
            IngredientUnit = ingredientUnit;
            IngredientName = ingredientName;
        }
        public int IngredientUnit { get; set; }
        public string IngredientName { get; set; }
    }
}
