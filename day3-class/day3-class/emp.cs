using System;
using System.Collections.Generic;
using System.Text;

namespace day3_class
{
    internal class emp
    {
        class Employee
        {
            string name;
            decimal salary;

            public Employee(string n, decimal s)
            {
                name = n;
                salary = s;
            }
            public virtual void GrossSalary()
            {

                Console.WriteLine("Gross Salary: " + salary);
            }
        }
    }
}
