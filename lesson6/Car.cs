using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    public class Car
    {
        public Car()
        {
            Console.WriteLine("From car Without Parameters");
        }

        public Car(int x)
        {
            Console.WriteLine("From int const");
        }
        
        public Car(double y)
        {
            Console.WriteLine("From double const");
        }


        private string[] item = new string[5];
        public string this[int x, int y]
        {
            get { return item[x]; }
            set { item[x] = value; }
        }
        protected string name { get; set; }
        protected int year { get; set; }
        protected int weight { get; set; }
        protected string engine { get; set; }
        protected int capacity { get; set; }
    }
}
