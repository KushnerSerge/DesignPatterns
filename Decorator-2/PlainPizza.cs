using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_2
{
    public class PlainPizza : Pizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
