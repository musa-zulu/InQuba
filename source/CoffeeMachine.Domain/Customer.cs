namespace CoffeeMachine.Domain
{
    public class Customer
    {
        public Customer(string customerName, Drink drink)
        {
            Drink = drink;
            CustomerName = customerName;
        }

        public Drink Drink { get; set; }
        public string CustomerName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ordered {1}", CustomerName, Drink);
        }
    }
}
