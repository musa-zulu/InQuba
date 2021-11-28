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
    public class Cappuccino : Coffee
    {
        public Cappuccino(int amountOfBeans) : base("Cappuccino", amountOfBeans) { }
    }

    public class PlainCoffee : Coffee
    {
        public PlainCoffee(int amountOfBeans) : base("Coffee", amountOfBeans) { }
    }

    public class Latte : Coffee
    {
        public Latte(int amountOfBeans) : base("Latte", amountOfBeans) { }
    }
}
