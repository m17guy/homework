using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sqlprobs
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlconection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\homework\lessons\10.12.18\sqlprobs\sqlprobs\Database1.mdf;Integrated Security=True";
            SqlConnection myconnect = new SqlConnection(sqlconection);
            string answer;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("what would you like to do?");
                    Console.WriteLine("1. add wrestler");
                    Console.WriteLine("2. find restler");
                    Console.WriteLine("3. leave");
                    answer = Console.ReadLine();
                    myconnect.Open(); // its better to ahve it open for a short time if it isnt being used for multipol seconds
                    if ("1" == answer)
                    {
                        SqlCommand mycommand = new SqlCommand(addrestler(), myconnect);
                        mycommand.ExecuteNonQuery();
                    }
                    if ("2" == answer)
                    {
                        SqlCommand mycommand = new SqlCommand(findrestler(), myconnect);
                        SqlDataReader reader = mycommand.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4]);
                        }
                        reader.Close();
                    }
                    myconnect.Close(); // its better to ahve it open for a short time if it isnt being used for multipol seconds
                    Console.ReadKey();
                } while (answer != "3");
            }
            catch(Exception e)
            {
                Console.WriteLine("we faild");
                Console.WriteLine(e.Message);
            }
            finally
            {
                myconnect.Close();
            }
        }
        static string addrestler()
        {
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("win num:");
            string winnum = Console.ReadLine();
            Console.WriteLine("loss num:");
            string lossnum = Console.ReadLine();
            Console.WriteLine("brain state:");
            string brain = Console.ReadLine();
            return $"insert into restlers values ('{name}',{winnum},{lossnum},'{brain}')";
        }
        static string findrestler()
        {
            Console.WriteLine("wins:");
            string wins = Console.ReadLine();
            Console.WriteLine("loss:");
            string loss = Console.ReadLine();
            return $"select * from restlers where fightwin>={wins} and fightloss<={loss}";
        }
    }
}
