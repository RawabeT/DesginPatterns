using System;
namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
        void buildDough();
        void buildSauce();
        void buildTopping();
        void reset();
    }
}
