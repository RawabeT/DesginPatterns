using System;
using AbstractFactory.Specifications;

namespace AbstractFactory.Factories
{
    public interface IFontsAbstractFactory
    {
        public Iilatic makeIlaticFont();

        public IBold makeBoldFont();
    }
}
