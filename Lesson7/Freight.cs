using lesson7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    public class Freight : Car
    {
        protected int weight { get; set; }
        protected string name { get; set; }
        protected int capacity { get; set; }
    }

}
