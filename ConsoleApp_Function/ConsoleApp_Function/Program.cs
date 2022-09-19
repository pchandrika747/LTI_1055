using System;

namespace ConsoleApp_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(32, 24);
            GetDetails("Chandu", 21, "Student");
            GetDetails(Designation: ".NET", Name: "Chandu", Age: 21) ;

            Console.ReadKey();
        }

        public static void Sum(int a , int b)
        {
            Console.WriteLine("{0}+{1}={2}", a, b, (a + b));
        }
        // named PArameters
        public static void GetDetails(string name, int age, string designation)
        {

            Console.WriteLine(" Name :" + name + " Designation :" + designation + " Age :" + age);
        }
    }
    public static void InterestAmount(decimal amount, decimal rate,int term=2)
    {
        decimal Interest = amount * rate * term;

        Console.WriteLine();
    }
}
