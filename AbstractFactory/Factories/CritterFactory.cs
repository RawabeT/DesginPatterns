using System;
using AbstractFactory.Specifications;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class CritterFactory : IFontsAbstractFactory
    {
        public IBold makeBoldFont()
        {
            return new CritterBold();

        }

        public Iilatic makeIlaticFont()
        {
            return new CritterIlatic();

        }
    }
}
