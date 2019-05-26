using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_Demo
{
  public  class Calculate
    {
        public static int Sum(int a,int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Division(int a, int b)
        {
            if (a==0)
            {
                return 0;
            }
            return a / b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
