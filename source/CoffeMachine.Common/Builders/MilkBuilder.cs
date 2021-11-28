using CoffeeMachine.Domain;
using PeanutButter.RandomGenerators;

namespace CoffeMachine.Common.Builders
{
    public class MilkBuilder : GenericBuilder<MilkBuilder, Milk>
    {
        public MilkBuilder WithIngredientName(string ingredientName)
        {
            return WithProp(x => x.IngredientName = ingredientName);
        }
    }
}
