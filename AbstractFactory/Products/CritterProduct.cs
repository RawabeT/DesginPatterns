using System;
using AbstractFactory.Specifications;

namespace AbstractFactory.Products
{
    public class CritterBold : IBold
    {
        public string writeIBoldAlphabatics()
        {
            return "Your text changed to Critter with Bold pro";
        }
    }

    public class CritterIlatic : Iilatic
    {
        public string writeIilaticAlphabatics()
        {
            return "Your text changed to Critter with Ilatic pro";
        }
    }
}
