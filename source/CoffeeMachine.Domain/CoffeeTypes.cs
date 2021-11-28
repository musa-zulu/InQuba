namespace CoffeeMachine.Domain
{
    /// <summary>
    /// These classes demonstrate open close principle,
    /// We can be able to extend the class Coffee without having to modify it,
    /// All we have to do is to extend on it, if we want to add another type of coffee it will be easy to do it here 
    /// by extending the class coffee.
    /// 
    /// Also Single Responsibility Principle is applied since each module is only responsible for one thing only.
    /// </summary>
    public class Cappuccino : Ingredient
    {
        private const string _coffeName = "Cappuccino";
        public Cappuccino(int amountOfBeans) : base(_coffeName, amountOfBeans) { }
    }

    public class Coffee : Ingredient
    {
        private const string _coffeName = "Coffee";
        public Coffee(int amountOfBeans) : base(_coffeName, amountOfBeans) { }
    }

    public class Latte : Ingredient
    {
        private const string _coffeName = "Latte";
        public Latte(int amountOfBeans) : base(_coffeName, amountOfBeans) { }
    }
}
