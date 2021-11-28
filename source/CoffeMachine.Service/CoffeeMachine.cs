using CoffeeMachine.Domain;
using CoffeeMachine.Tests.Builders;
using System;

namespace CoffeeMachine.Service
{
    public class CoffeeMachine
    {
        private int MaximumBeanCapacity = 25;
        private int MaximumMilkCapacity = 20;
        private int CoffeeOption;
        private int MilkOption;
        private int SugarOption;

        public CoffeeMachine()
        {
            PrintInstructions();
        }

        private void PrintInstructions()
        {
            Console.Write("\t\t\t\tWelcome to Coffee Maker Machine" +
                "\n\t\t\t=============================================\n");
            CoffeeOptions();
            TakeUserInput();
        }

        private static void CoffeeOptions()
        {
            Console.Write("Choose a number on the following options. e.g 1 if you want to make coffee\n");
            Console.Write(" (1) Coffee\n (2) Cappuccino \n (3) Latte\n Option :: ");
        }

        private void TakeUserInput()
        {
            CoffeeSelection();
            MakeCoffee();
        }

        private void CoffeeSelection()
        {
            while (!int.TryParse(Console.ReadLine(), out CoffeeOption))
            {
                PrintInputError("1-3");
            }
        }

        private void MilkSelection()
        {
            string milkOption = GetMilkOption();
            while (!int.TryParse(milkOption, out MilkOption))
            {
                milkOption = GetMilkOption();
            }
        }

        private void SugarSelection()
        {
            string sugarOption = GetSugarOption();
            while (!int.TryParse(sugarOption, out SugarOption))
            {
                sugarOption = GetSugarOption();
            }
        }

        private void MakeCoffee()
        {
            if (CoffeeOption > 0 && CoffeeOption <= 3)
            {
                var builder = new DrinkBuilder();
                switch (CoffeeOption)
                {
                    case 1:
                        CoffeeIngredients();
                        builder.WithDrinkName("Coffee")
                               .WithIngredients(new DrinkIngredients(new Coffee(2), new Milk(MilkOption), new Sugar(SugarOption)));
                        break;
                    case 2:
                        CappuccinoIngredients();
                        builder.WithDrinkName("Cappuccino")
                               .WithIngredients(new DrinkIngredients(new Cappuccino(5), new Milk(3), new Sugar(SugarOption)));
                        break;
                    case 3:
                        LatteIngredients();
                        builder.WithDrinkName("Latte")
                               .WithIngredients(new DrinkIngredients(new Latte(3), new Milk(2), new Sugar(SugarOption)));
                        break;
                }

                DisplayOrderFor(builder);
                OrderMoreCoffeeOrExitProgram();
            }
            else
            {
                PrintInputError("1-3");
                TakeUserInput();
            }
        }

        private static void DisplayOrderFor(DrinkBuilder builder)
        {
            Console.WriteLine(new DisplayOrder(builder.Build()).ToString());
        }

        private void CoffeeIngredients()
        {
            SetMilkOptions();
            SugarSelection();
            if (MilkOption == 1)
                CalculateMilkCapacity(1);
            CalculateBeansCapacity(2);
        }

        private void LatteIngredients()
        {
            SugarSelection();
            CalculateBeansCapacity(3);
            CalculateMilkCapacity(2);
        }

        private void CappuccinoIngredients()
        {
            SugarSelection();
            CalculateBeansCapacity(5);
            CalculateMilkCapacity(3);
        }

        private void CalculateBeansCapacity(int beansUnits)
        {
            MaximumBeanCapacity -= beansUnits;
        }

        private void CalculateMilkCapacity(int milkUnits)
        {
            MaximumMilkCapacity -= milkUnits;
        }

        private void SetMilkOptions()
        {
            MilkSelection();
            if (MilkOption > 1)
            {
                PrintInputError("0-1");
                SetMilkOptions();
            }
        }

        private void OrderMoreCoffeeOrExitProgram()
        {
            int option = MakeAnotherCoffeeOption();

            if (option > 1)
            {
                PrintInputError("0-1");
                OrderMoreCoffeeOrExitProgram();
            }

            if (option == 1)
            {
                CheckIngredientsCapacity();
                MakeAnotherCoffeOrExit();
            }
            else
            {
                //print type off to shut down the machine 
                ShudownProgram();
            }
        }

        private void MakeAnotherCoffeOrExit()
        {
            if (MaximumBeanCapacity > 0 && MaximumMilkCapacity > 0)
            {
                CoffeeOptions();
                TakeUserInput();
            }
            else
            {
                PrintCapacityErrors(string.Format("Machine has {0} beans and {1} milk units, we are unable to make a coffee.", MaximumBeanCapacity, MaximumMilkCapacity));
            }
        }

        private void CheckIngredientsCapacity()
        {
            var milkCapacity = CheckMilkCapacity();
            var beansCapacity = CheckBeansCapacity();
            if (!string.IsNullOrEmpty(milkCapacity))
            {
                PrintCapacityErrors(milkCapacity);
            }

            if (!string.IsNullOrEmpty(beansCapacity))
            {
                PrintCapacityErrors(beansCapacity);
            }
        }

        private static int MakeAnotherCoffeeOption()
        {
            Console.WriteLine("\nWould you like to make another coffee ?\n select 1 for (Yes) or 0 for (No)");
            int option;

            while (!int.TryParse(Console.ReadLine(), out option))
            {
                PrintInputError("0-1");
            }
            return option;
        }

        private static string TerminateOptions()
        {
            Console.WriteLine("please type 'off' to shut down the machine");
            string terminateOption = Console.ReadLine();
            return terminateOption;
        }

        private static string GetMilkOption()
        {
            Console.WriteLine("\nWould you like to add milk?, \nplease select 1 if (yes) or 0 if (No)");
            string milkOption = Console.ReadLine();
            return milkOption;
        }

        private static string GetSugarOption()
        {
            Console.WriteLine("\nPlease enter an amount of sugar you would like with your coffee?, \n");
            string sugarOption = Console.ReadLine();
            return sugarOption;
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

        private static void PrintInputError(string range)
        {
            Console.WriteLine("Invalid option, please select numbers between " + range);
        }

        private static void PrintCapacityErrors(string error)
        {
            Console.WriteLine(error);
            return;
        }

        private static void ShudownProgram()
        {
            string terminateOption = TerminateOptions();
            while (terminateOption != "off")
            {
                terminateOption = TerminateOptions();
            }

            if (terminateOption.ToLowerInvariant() == "off")
            {
                //kill the program.
            }
        }
    }
}
