using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_1
{
    public class BruCoffee : CoffeeTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Water Boild");
        }

        protected override void AddMilk()
        {
            Console.WriteLine("Milk Added");
        }

        protected override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }
        protected override void AddCoffeePowder()
        {
            Console.WriteLine("Bru Coffee Powder Added");
        }
    }
}
