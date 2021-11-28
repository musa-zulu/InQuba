using CoffeeMachine.Domain;
using PeanutButter.RandomGenerators;

namespace CoffeMachine.Common.Builders
{
    public class SugarBuilder : GenericBuilder<SugarBuilder, Sugar>
    {
        public SugarBuilder WithIngredientName(string ingredientName)
        {
            return WithProp(x => x.IngredientName = ingredientName);
        }
    }
}
