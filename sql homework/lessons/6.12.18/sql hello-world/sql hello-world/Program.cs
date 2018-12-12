using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sql_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\homework\lessons\6.12.18\sql hello-world\sql hello-world\sql-db.mdf""; Integrated Security = True";
            SqlConnection myconect = new SqlConnection(connetion);
            try
            {
                myconect.Open();
                Console.WriteLine("im in");
                Console.WriteLine("name:");
                string pokname = Console.ReadLine();
                Console.WriteLine("type:");
                string poktype = Console.ReadLine();
                Console.WriteLine("lvl:");
                string poklvl = Console.ReadLine();
                string mycomand = $"insert into animals values('{pokname}','{poktype}',{poklvl});";
                SqlCommand makepok = new SqlCommand(mycomand, myconect);
                int rowmade = makepok.ExecuteNonQuery();
                Console.WriteLine("created " + rowmade + " new pok");
            }
            catch(Exception e)
            {
                Console.WriteLine("oh shit");
            }
            finally
            {
                myconect.Close();
            }
        }
    }
}
