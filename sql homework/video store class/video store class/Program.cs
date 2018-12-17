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
                Console.WriteLine("2. add movie");
                Console.WriteLine("3. find movies");
                Console.WriteLine("4. rent a movie");
                Console.WriteLine("5. return a movie");

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
                    case ("5"):
                        webflix.returnmovie();
                        break;
                    case ("q"):
                        break;
                    default:
                        Console.WriteLine("i dont understand");
                        break;
                        
                }
                Console.ReadKey();
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
        public void updatecustomerandmovie(bool take, int cusid, int movieid)
        {
            SqlCommand rentmovie;
            if (take)
            {
                rentmovie = new SqlCommand("update customer set movietaken=(movietaken+1) where customerId=" + cusid, myconnect);
            }
            else
            {
                rentmovie = new SqlCommand("update customer set movietaken=(movietaken-1) where customerId=" + cusid, myconnect);
            }
            try
            {
                myconnect.Open();
                rentmovie.ExecuteNonQuery();
                Console.WriteLine("customer updated");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myconnect.Close();
            }
            if (take)
            {
                rentmovie = new SqlCommand("update movies set taken=(taken+1) where moviesId=" + movieid, myconnect);
            }
            else
            {
                rentmovie = new SqlCommand("update movies set taken=(taken-1) where moviesId=" + movieid, myconnect);
            }
            try
            {
                myconnect.Open();
                rentmovie.ExecuteNonQuery();
                Console.WriteLine("movie updated");
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
        public void rentmovie()
        {
            Console.WriteLine("customer name:");
            string cusname = Console.ReadLine();
            SqlCommand takemovie = new SqlCommand($"select customerId, name from customer where name like '%{cusname}%'", myconnect);
            try
            {
                myconnect.Open();
                SqlDataReader reader = takemovie.ExecuteReader();
                if (!reader.Read())
                {
                    Console.WriteLine("no customers with that name were found");
                    return;
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
            cusname = Console.ReadLine();
            Console.WriteLine("name of the movie you want to take:");
            string moviename = Console.ReadLine();
            takemovie=new SqlCommand($"select moviesId, name from movies where name like '%{moviename}%' and amount>taken", myconnect);
            try
            {
                myconnect.Open();
                SqlDataReader reader = takemovie.ExecuteReader();
                if (!reader.Read())
                {
                    Console.WriteLine("no movies with that name are avilabul");
                    return;
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
                myconnect.Close();
                updatecustomerandmovie(true, int.Parse(cusname), int.Parse(moviename));

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myconnect.Close();
            }
        }
        public void returnmovie()
        {
            Console.WriteLine("customer name:");
            string cusname = Console.ReadLine();
            SqlCommand returnmovie = new SqlCommand($"select customerId, name from customer where name like '%{cusname}%'", myconnect);
            try
            {
                myconnect.Open();
                SqlDataReader reader = returnmovie.ExecuteReader();
                if (!reader.Read())
                {
                    Console.WriteLine("no customers with that name were found");
                    return;
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
            cusname = Console.ReadLine();
            returnmovie = new SqlCommand($"select renting.rentId, movies.name from renting inner join movies on renting.moviesId=movies.moviesId where renting.customerId={cusname} and returned=0", myconnect);
            try
            {
                myconnect.Open();
                SqlDataReader reader = returnmovie.ExecuteReader();
                if (!reader.Read())
                {
                    Console.WriteLine("no movies need to be returned");
                    return;
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
            string moviename = Console.ReadLine();
            returnmovie = new SqlCommand($"update renting set returned=1 where rentId = {moviename}", myconnect);
            try
            {
                myconnect.Open();
                returnmovie.ExecuteNonQuery();
                Console.WriteLine("movie returned");
                myconnect.Close();
                updatecustomerandmovie(false, int.Parse(cusname), int.Parse(moviename));
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
    }
}
