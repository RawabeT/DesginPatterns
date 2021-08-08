using PizzaBuilder.Products;

namespace PizzaBuilder.Builders
{
    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza _whitePizza = new WhitePizza();

        public WhitePizzaBuilder()
        {
            this.reset();
        }

        public void buildDough()
        {
            this._whitePizza.Add("White Dough");
        }
        public void buildSauce()
        {
            this._whitePizza.Add("Sauce");
        }
        public void buildTopping()
        {
            this._whitePizza.Add("Topping");
        }
        public void reset()
        {
            this._whitePizza = new WhitePizza();
        }

        public WhitePizza GetProduct()
        {
            WhitePizza result = this._whitePizza;
            this.reset();
            return result;
        }

    }
}
