namespace CoffeeMachine.Domain
{
    /// <summary>
    /// Liskov substitution principle,
    /// Derived classes must be substitutable for their base classes
    /// Milk is an Ingredient it we can use it as an ingredient
    /// </summary>
    public class Milk : Ingredient
    {
        public Milk(int milkAmount) : base("Milk", milkAmount)
        {
        }
    }
}
