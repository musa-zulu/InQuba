namespace CoffeeMachine.Domain
{
    /// <summary>
    /// Liskov substitution principle,
    /// Derived classes must be substitutable for their base classes
    /// Sugar is an Ingredient it we can use it as an ingredient
    /// </summary>
    public class Sugar : Ingredient
    {
        public Sugar(int amountOfSugar) : base("Sugar", amountOfSugar)
        {
        }
    }
}
