using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace video_store_class
{
    class Program
    {
        static void Main(string[] args)
        {
            vidstore webflix = new vidstore();
            string answer="";
            while (answer != "q")
            {
                Console.Clear();
                Console.WriteLine("1. add customer");
                Console.WriteLine("2. buy movie");
                Console.WriteLine("3. find movies");
                Console.WriteLine("4. rent a movie");

                Console.WriteLine("Q. to leave");
                answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case ("1"):
                        webflix.addcust();
                        break;
                    case ("2"):
                        webflix.buymovie();
                        break;
                    case ("3"):
                        webflix.findmovie();
                        break;
                    case ("4"):
                        webflix.rentmovie();
                        break;
                    case ("q"):
                        break;
                    default:
                        Console.WriteLine("i dont understand");
                        break;

                }

            }
        }
    }
    class vidstore
    {
        private static string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\homework\sql homework\video store class\video store class\Database1.mdf"";Integrated Security=True";
        static SqlConnection myconnect = new SqlConnection(connectstring);
        public void addcust()
        {
            Console.WriteLine("name of customer:");
            string name = Console.ReadLine();
            Console.WriteLine("customer addres:");
            string addres = Console.ReadLine();
            Console.WriteLine("phone number:");
            string phonum = Console.ReadLine();
            try
            {
                SqlCommand mycommand = new SqlCommand($"insert into customer values ('{name}','{addres}',{phonum},0)", myconnect);
                myconnect.Open();
                mycommand.ExecuteNonQuery();
                Console.WriteLine("customer added");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myconnect.Close();
            }
        }
        public void buymovie()
        {
            Console.WriteLine("name of movie:");
            string name = Console.ReadLine();
            Console.WriteLine("type:");
            string type = Console.ReadLine();
            Console.WriteLine("year it came out:");
            string year = Console.ReadLine();
            Console.WriteLine("amount bought");
            string amount = Console.ReadLine();
            try
            {
                SqlCommand mycommand = new SqlCommand($"insert into movies values ('{name}','{type}',{year},{amount},0)", myconnect);
                myconnect.Open();
                mycommand.ExecuteNonQuery();
                Console.WriteLine("movie added");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myconnect.Close();
                Console.ReadKey();
            }
        }
        public void findmovie()
        {
            Console.WriteLine("1. find movie by name");
            Console.WriteLine("2. find movies by type");
            Console.WriteLine("3. go back");
            string answer = Console.ReadLine();
            SqlCommand mycommand = null;
            switch (answer)
            {
                case ("1"):
                    Console.WriteLine("movie name:");
                    string name = Console.ReadLine();
                    mycommand = new SqlCommand($"select * from movies where name='{name}'", myconnect);
                    break;
                case ("2"):
                    Console.WriteLine("type");
                    string type = Console.ReadLine();
                    mycommand = new SqlCommand($"select * from movies where type='{type}'", myconnect);
                    break;
                case ("3"):
                    return;
            }
            try
            {
                myconnect.Open();
                SqlDataReader reader = mycommand.ExecuteReader();
                if (!reader.Read())
                {
                    Console.WriteLine("no movies found");
                }
                else
                {
                    do
                    {
                        Console.WriteLine($"name: {reader[1]}, type: {reader[2]}, year {reader[3]}, amount availabel {reader[4]}");
                    } while (reader.Read());
                    reader.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
                myconnect.Close();
            }
        }
        public void rentmovie() //need a lot of work
        {
            Console.WriteLine("customer name:");
            string cusname = Console.ReadLine();
            SqlCommand takemovie = new SqlCommand($"select customerId, name from customer where name='{cusname}'", myconnect);
            try
            {
                myconnect.Open();
                SqlDataReader reader = takemovie.ExecuteReader();
                if (!reader.Read())
                {
                    Console.WriteLine("no customers with that name were found");
                }
                else
                {
                    do
                    {
                        Console.WriteLine($"Id: {reader[0]}, name: {reader[1]}");
                    } while (reader.Read());
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myconnect.Close();
            }
            Console.WriteLine("custemer Id:");
            Console.WriteLine("(or Q to go back)");
            cusname = Console.ReadLine();
            if (cusname.ToLower() == "q")
            {
                return;
            }
            Console.WriteLine("name of the movie you want to take:");
            string moviename = Console.ReadLine();
            takemovie=new SqlCommand($"select moviesId, name from movies where name='{moviename}'", myconnect);
            try
            {
                myconnect.Open();
                SqlDataReader reader = takemovie.ExecuteReader();
                if (!reader.Read())
                {
                    Console.WriteLine("no movies with that name were found");
                }
                else
                {
                    do
                    {
                        Console.WriteLine($"Id: {reader[0]}, name: {reader[1]}");
                    } while (reader.Read());
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myconnect.Close();
            }
            Console.WriteLine("movie Id:");
            Console.WriteLine("(or Q to go back)");
            moviename = Console.ReadLine();
            //Console.WriteLine("take date"); 
            string takedate = "10.9.18";
            //Console.WriteLine("return date");
            string returndate = "17.9.18";
            takemovie = new SqlCommand($"insert into renting values({cusname},{moviename},'{takedate}','{returndate}',0)",myconnect);
            try
            {
                myconnect.Open();
                takemovie.ExecuteNonQuery();
                Console.WriteLine("movie rented");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myconnect.Close();
            }
            Console.ReadKey();
        }
    }
}
