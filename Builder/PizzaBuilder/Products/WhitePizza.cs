using System.Collections.Generic;
namespace PizzaBuilder.Products
{
    public class WhitePizza
    {
        private List<object> whitePizza = new List<object>();
        public void Add(string part)
        {
            this.whitePizza.Add(part);
        }
        public string WhitePizzalistParts()
        {
            string str = "";
            for (int i = 0; i < this.whitePizza.Count; i++)
            {
                str += this.whitePizza[i] + ",";
            }
            return "white Pizza parts: " + str;
        }
    }
}
