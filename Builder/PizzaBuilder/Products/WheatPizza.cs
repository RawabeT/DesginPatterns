using System;
using System.Collections.Generic;

namespace PizzaBuilder.Products
{
    public class WheatPizza
    {
        private List<object> wheatPizza = new List<object>();
        public void Add(string part)
        {
            this.wheatPizza.Add(part);
        }
        public string wheatPizzalistParts()
        {
            string str = "";
            for (int i = 0; i < this.wheatPizza.Count; i++)
            {
                str += this.wheatPizza[i] + ",";
            }
            return "wheat Pizza parts: " + str;
        }
    }
}
