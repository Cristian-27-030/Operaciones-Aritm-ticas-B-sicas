using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones_Aritméticas_Básicas
{
    class Class1
    {
        double x, y;


        public Class1(double x, double y)
        {
            this.x = x;
            this.y = y; 
        }


        public double opsuma()
        {
            return x + y;
        }


        public double opresta()
        {
            return x - y;
        }


        public double opmultiplicar()
        {
            return x * y;
        }


        public double opdivision()
        {
            return x / y;
        }


        public double opresiduo()
        {
            return x % y;
        }
    }
}
