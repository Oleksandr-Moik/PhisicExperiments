using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisicExperiments
{
    public class Vector
    {
        public double X {get;set;}
        public double Y {get;set; }

        public Vector()
        {
            X = 0;
            Y = 0;
        }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
