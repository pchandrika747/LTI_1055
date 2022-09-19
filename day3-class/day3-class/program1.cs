using System;
using System.Collections.Generic;
using System.Text;

namespace day3_class
{
    internal class program1

    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ria", 15000);
        emp.GrossSalary();
            Manager man = new Manager(44, 20000, "Banu", 25555);

        //man.GrossSalary();

        Employee e = man;
        e.GrossSalary();
        man.GrossSalary();

    }
}
