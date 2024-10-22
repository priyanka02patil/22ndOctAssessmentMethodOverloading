using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22ndOctAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. WAP to overload add method

            //AddExample add1 = new AddExample();

            //Console.WriteLine(add1.Add(12,15));
            //Console.WriteLine(add1.Add(13,14,16));
            //Console.WriteLine(add1.Add(12.5,4));
            //Console.WriteLine(add1.Add(24,25.6));

            //Employee emp1 = new Employee("priyanka", "IT");

            //Console.WriteLine(emp1.display());

            //Employee emp2 = new Employee(101, "nikhil", "Comp", 45000);

            //Console.WriteLine(emp2.display());

            Payment.PayBill(1000);

            Payment.payBill(2000, "phonepay");
           



        }
    }
}
