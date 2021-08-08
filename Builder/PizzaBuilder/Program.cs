using System;
using PizzaBuilder.Builders;

namespace PizzaBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director dir = new Director();
            IPizzaBuilder builder;            

            dir.PizzaBuilder = builder = new WhitePizzaBuilder(); ;
            dir.makePizza();
            Console.WriteLine((builder as WhitePizzaBuilder).GetProduct().WhitePizzalistParts());

            dir.PizzaBuilder = builder = new WheatPizzaBuilder();
            dir.makePizzaNoSauce();
            Console.WriteLine((builder as WheatPizzaBuilder).GetProduct().wheatPizzalistParts());

            //Bonus 1
            builder.buildDough();
            builder.buildSauce();
            Console.WriteLine((builder as WheatPizzaBuilder).GetProduct().wheatPizzalistParts());

            Console.WriteLine("Choose Dough: ");
            string dough = Console.ReadLine();

            Console.WriteLine("Choose Sauce: ");
            string Sauce = Console.ReadLine();

            Console.WriteLine("Choose Topping: ");
            string Topping = Console.ReadLine();

            Console.WriteLine((builder as WheatPizzaBuilder).GetProduct().wheatPizzalistParts() + dough+" "+ Sauce + " " + Topping);
        }
    }
}
