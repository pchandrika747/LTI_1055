using System;
using System.Data.SqlClient;
using System.Data;

namespace Day_5
{
    internal class Sqlconnectio
    {
        static void Main(String[] args)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=Chandrika;Initial Catalog=LTI;Integrated Security=True");

                SqlCommand com = new SqlCommand();

                com.Connection = con;

                com.CommandText = "insert into table1(id,Name)values(@id,@Name)";
                SqlParameter p1 = new SqlParameter("@ID", SqlDbType.Int);
                Console.WriteLine("Enter id of student");
                int id = Convert.ToInt32(Console.ReadLine());
                p1.Value = id;
                com.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@NAME", SqlDbType.VarChar);
                Console.WriteLine("Enter name of student");
                string Name = Console.ReadLine();
                p2.Value = Name;
                com.Parameters.Add(p2);


                con.Open();
                com.ExecuteNonQuery();



                Console.WriteLine("Record Added Successfully");



            }
            catch (Exception e)

            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
