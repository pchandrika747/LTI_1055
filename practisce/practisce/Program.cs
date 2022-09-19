using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace practisce
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Sum(1, 2);

            //void Sum(int a, int b, int c=4)
            //{
            //    int s = a+b+c;
            //    Console.WriteLine(s);
            //}

        //    chandu( "Moon",  6);  // function_name 
        //    chandu("sky", 3);
        //    chandu("stars", 8);
        //    // we can use function to print output repeatedly 


        //    void chandu(string a, int b)
        //    {
        //        string s = a;
        //        int c = b;
                
        //        Console.WriteLine("{0} {0}",s,c); // string formating 
        //    }
        //}



        //int a = 10;
        //int b = 20;
        //int c ;
        //c = 36;



        //    int x = 20;
        //    int y = 20;

        //}

        // void chandu() // scope is the life time of variable 
        //{
        //    int x = 30;



        //int functionname(int a)

        //{
        //    Console.WriteLine(a);
        //    return 2;
        //}


        //int a = 10;
        //float f = (float) a;

        //float b = 30.5f;
        //int c = (int)b ;

        //long l = 200;
        //int k= (int) l;

        // Object obj =10; // boxing is converting value type to

        //Console.WriteLine(a);
        //Console.WriteLine(f);
        //Console.WriteLine(c);
        //Console.WriteLine(k);


        // function is 

        // void functionname (parameterlist)

        // functionname(arguments); calling a function






        string name = "Pen";
        string v = "book";
        Console.WriteLine("Hello " + name);
            string st = "Hello" + name + "!";
        string str = string.Format("Hello {0},{1} !", name, v); // string formating 
        string str1 = $"Hello {name}";
        Console.WriteLine(st);
            Console.WriteLine(str);
            Console.WriteLine(str1);



           // Items("pen", "pencil", "book", "box", "pop", "polo");
    }
    // single array
    //int[] ar = new int[4];
    //ar[0] = 10;
    //ar[1] = 20; 
    //ar[2] = 30;
    //ar[3] = 40;

    //for (int i= 0; i < ar.Length; i++)
    //{
    //    Console.Write(ar[i]);
    //}
    //

    // rows and columns 
    //int[,] ar = new int[2, 2];
    //ar[0, 0] = 10;
    //ar[0, 1] = 20;
    //ar[1, 0] = 30;
    //ar[1, 1] = 40;

    //for(int i= 0; i < ar.GetLength(0); i++)  // row
    //{
    //    for(int j=0; j < ar.GetLength(1); j++) //coloumn
    //    {
    //        Console.Write($"{ar[i,j]} ");  //$"{}"
    //    }

    //    Console.WriteLine();
    //}

    // array of arrays (jaged array)

    //int[][] jag = new int[2][];
    //jag[0] = new int[] {10,20,30};
    //jag[1] = new int[] {1,3};

    //for (int i= 0; i < jag.Length; i++)
    //{
    //    for(int j=0; j < jag[i].Length; j++)
    //    {
    //        Console.Write($"{}");
    //    }
    //    Console.WriteLine();
    //}

    // params is a key word that is used to pass an array when the parameters length is undecided


    //public static void Items(params string[] name)
    //{
    //    foreach(string n in name)

    //    {
    //        Console.WriteLine(n);
    //    }
    //}

    //    sum(3, 2.5f);
    //    sum(1.5f, 2);
    //    sum(2, 4);
    //    sum(2, 2, 2);

    //}
    ////method overloading is the methos having same method name but different signatures
    ////diff number of parameters, different datatype of parameters, different sequence- signatures
    //public static void sum(int a, int b)
    //{
    //    Console.WriteLine("{0}+{1}={2}", a, b, (a + b));
    //}
    //public static void sum(int a, int b, int c)
    //{
    //    Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, (a + b + c));
    //}
    //public static void sum(int a, float b)
    //{
    //    Console.WriteLine("{0}+{1}={2}", a, b, (a + b));
    //}
    //public static void sum(float a, int b)
    //{
    //    Console.WriteLine("{0}+{1}={2}", a, b, (a + b));
    //}


    //    {
    //        Items("Pen", 1, '#', 2.5f);

    //    }
    ////params is a keyword that is similar to array but it is used to pass an array when the parameters' length is undecided 
    //public static void Items(params object[] name)
    //{
    //    foreach (object n in name)
    //    {
    //        Console.WriteLine(n);
    //    } }
}

}

