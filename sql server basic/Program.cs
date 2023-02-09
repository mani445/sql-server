using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace sql_server_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8HUVM9H\\SQLEXPRESS;Initial Catalog=mani;Integrated Security=True");
             int id, salary,age;
               string name, desgination;
               Console.Write("enter name:  ");
               name = Console.ReadLine();
               Console.Write("enter age:  ");
               age = int.Parse(Console.ReadLine());
               Console.Write("enter desgination:  ");
               desgination = Console.ReadLine();
               Console.Write("enter id:  ");
               id = int.Parse(Console.ReadLine());
               Console.Write("enter salary:  ");
               salary = int.Parse(Console.ReadLine());
               string sql = $"insert into emp values('{name}',{age},'{desgination}',{id},{salary})";
              
            con.Open();
            
            
            
            SqlCommand cmd1 = new SqlCommand("delete from emp where id = 4", con);
            SqlCommand cmd2 = new SqlCommand("select*from emp",con); 
            cmd1.ExecuteNonQuery();
            SqlDataReader dr = cmd2.ExecuteReader();
           

            while (dr.Read())
            {
                Console.WriteLine(dr[0]+"\t"+ dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4]);
            }
        }
    }
}
