using lesson7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lesson7
{
    internal class DodgeRam : Freight
    {
        protected int tonna { get; set; }
        protected string x { get; set; }
        protected int mnogo { get; set; }

        public override double calculate(ref int num1, int num2)
        {
            num1 += 2;
            return base.calculate(ref num1, num2);
        }
    }
}
