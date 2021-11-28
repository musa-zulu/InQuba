using CoffeeMachine.Domain;
using PeanutButter.RandomGenerators;

namespace CoffeMachine.Common.Builders
{
    public class CoffeBuilder : GenericBuilder<CoffeBuilder, Coffee>
    {
        public CoffeBuilder WithIngredientName(string ingredientName)
        {
            return WithProp(x => x.IngredientName = ingredientName);
        }
        public CoffeBuilder WithIngredientUnit(int ingredientUnit)
        {
            return WithProp(x => x.IngredientUnit = ingredientUnit);
        }
    }
}
