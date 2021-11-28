using CoffeeMachine.Tests.Builders;
using System.Text;

namespace CoffeeMachine.Service
{
    public class CoffeeMachine
    {
        private int MaximumBeanCapacity = 25;
        private int MaximumMilkCapacity = 20;

        public CoffeeMachine()
        {
            MakeCoffee();
        }

        private void MakeCoffee()
        {



            var builder = new DrinkBuilder();
            builder.WithDrinkName("musa")
                .Build();
            StringBuilder sb = new();
            //return "";

            MaximumBeanCapacity -= 
            var milkCapacity = CheckMilkCapacity();
            var beansCapacity = CheckBeansCapacity();
        }


        private string CheckBeansCapacity()
        {
            string responseMessage = string.Empty;
            if (MaximumBeanCapacity <= 0)
                responseMessage = "Sorry, the machine has ran out of beans!";
            return responseMessage;
        }

        private string CheckMilkCapacity()
        {
            string responseMessage = string.Empty;
            if (MaximumMilkCapacity <= 0)
                responseMessage = "Sorry, the machine has ran out of Milk!";
            return responseMessage;
        }
    }
}
