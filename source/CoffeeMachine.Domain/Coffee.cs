namespace CoffeeMachine.Domain
{
    /// <summary>
    /// Dependency Invesion Principle,
    /// Depend on abstraction, not on concretions.
    /// This coffee object is abstration layer
    /// </summary>
    public abstract class Coffee
    {
        public Coffee(string drinkName, int amountOfBeans)
        {
            DrinkName = drinkName;
            AmountOfBeans = amountOfBeans;
        }

        public int AmountOfBeans { get; set; }
        public string DrinkName { get; set; }
    }
}
