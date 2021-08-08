using System;
using AbstractFactory.Specifications;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    class StuzFactory : IFontsAbstractFactory
    {
        public IBold makeBoldFont()
        {
            return new StuzIBold();

        }

        public Iilatic makeIlaticFont()
        {
            return new StuzIilatic();

        }
    }
}
