using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22ndOctAssessment
{
    //2. WAP to overload constructor in Employee class

    public class Employee
    {
        private int empid,salary;
        private string name,deptname;

        public Employee(int empid,string name,string deptname,int salary) 
        {
            this.empid = empid;
            this.name = name;
            this.deptname = deptname;
            this.salary = salary;
        }

        public Employee(string name,string deptname)
        {
            this.name=name;
            this.deptname=deptname;
        }

        public string display()
        {
            return $"empid = {empid}, name = {name} , deptname = {deptname} , salary = {salary}";
        }




    }
}
