using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22ndOctAssessment
{
    public class AddExample
    {
        public int Add(int a,int b)
        {
            return a + b;//add
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(int a , double b)
        {
            return a + b;
        }

        public double Add(double a , int b)
        {
            return a + b;
        }
    }
}
