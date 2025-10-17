using Calculate.Icalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class UpCalculating:IUpCalculator
    {
        const double pi = 3.14;
        public int num3 { get; set; }
        public int num4 { get; set; }

        public int Exponentiation2(int num3)
        {
            return num3 * num3;
        }
        public int Exponentiation3(int num3)
        {
            return (num3 * num3 * num3);
        }
        public double Root(double num3)
        {
            double guess = num3 / 2.0;
            double epsilon = 1e-10;
            while (true)
            {
                double prevGuess = guess;
                guess = 0.5 * (guess + num3 / guess);
                double diff = guess - prevGuess;
                if (diff > 0)
                    diff = -diff;
                if (diff < epsilon)
                    break;
            }
            return guess;
        }
        public double Sin(int num3)
        {
            return (num3 * pi) / 30;
        }
        public double Cos(int num3)
        {
            return (num3 * pi) / 60;
        }
        public double Tan(int num3)
        {
            return (num3 * pi) / 90;
        }
    }
}
