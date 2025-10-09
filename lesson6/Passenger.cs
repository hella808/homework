using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    public class Passenger : Car
    {
        public Passenger():base(5)
        {
            Console.WriteLine("Hello from Van Without");
        }
        protected string engine { get; set; }
        protected string year { get; set; }
        protected string name { get; set; }
    }
}
