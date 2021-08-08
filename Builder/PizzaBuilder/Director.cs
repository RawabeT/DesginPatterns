namespace PizzaBuilder
{
    public class Director
    {
        private IPizzaBuilder _pizzaBuilder;

        public IPizzaBuilder PizzaBuilder
        {
            set
            {
                this._pizzaBuilder = value;
            }
        }

        public void makePizza()
        {
            this._pizzaBuilder.buildDough();
            this._pizzaBuilder.buildSauce();
            this._pizzaBuilder.buildTopping();
        }

        public void makePizzaNoSauce()
        {
            this._pizzaBuilder.buildDough();
            this._pizzaBuilder.buildTopping();
        }
    }
}
