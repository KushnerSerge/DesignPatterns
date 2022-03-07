using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_1
{
    public abstract class CoffeeTemplate
    {
        // PrepareCoffee method is the template method
        public void PrepareCoffee()
        {
            BoilWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();
            Console.WriteLine(this.GetType().Name + " is Ready");
        }
        protected abstract void BoilWater();
        protected abstract void AddMilk();
        protected abstract void AddSugar();
        protected abstract void AddCoffeePowder();
    }
}
