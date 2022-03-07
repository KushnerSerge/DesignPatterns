using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_2
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }

        private string AddVegetables()
        {
            return ", Vegetables added";
        }
    }
}
