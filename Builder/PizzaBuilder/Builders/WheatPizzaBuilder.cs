using PizzaBuilder.Products;

namespace PizzaBuilder.Builders
{
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza _WheatPizza = new WheatPizza();

        public WheatPizzaBuilder()
        {
            this.reset();
        }

        public void buildDough()
        {
            this._WheatPizza.Add("Wheat Dough");
        }
        public void buildSauce()
        {
            this._WheatPizza.Add("Sauce");
        }
        public void buildTopping()
        {
            this._WheatPizza.Add("Topping");
        }
        public void reset()
        {
            this._WheatPizza = new WheatPizza();
        }

        public WheatPizza GetProduct()
        {
            WheatPizza result = this._WheatPizza;
            this.reset();
            return result;
        }
    }
}
