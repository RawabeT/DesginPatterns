using System;
using AbstractFactory.Specifications;

namespace AbstractFactory.Products
{
    public class StuzIBold : IBold
    {
        public string writeIBoldAlphabatics()
        {
            return "Your text changed to Stuz with Bold pro";
        }
    }

    public class StuzIilatic : Iilatic
    {
        public string writeIilaticAlphabatics()
        {
            return "Your text changed to Stuz with Ilatic pro";
        }
    }
}
