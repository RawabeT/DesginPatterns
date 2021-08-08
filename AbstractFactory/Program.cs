using System;
using AbstractFactory.Products;
using AbstractFactory.Specifications;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
            Console.WriteLine("-----Good Desgin Pattren ^_^ -----");
        }
    }
}
