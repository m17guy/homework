using System;
using System.IO;
using System.Text;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f;
            try
            {
                //Example 1				
                f = new FileInfo("inFiles/Bubu.txt"); //create object to work with file 
                Console.WriteLine(f.FullName); //print path to file
                Console.WriteLine(Environment.CurrentDirectory); //print path to folder
                if (f.Exists) Console.WriteLine("Found bubu.txt file"); //print found if exists

                f = new FileInfo("inFiles/deadpool.txt");
                f.Create().Close(); /**  always closing stream when done  **/


                //Example 2 - read all text from file by path
                string fileStr = File.ReadAllText("inFiles/Bubu.txt");
                Console.WriteLine(fileStr);


                //Example 3 - Programmatically create folder & file
                string dirName = "outFiles";
                DirectoryInfo dir = new DirectoryInfo(dirName);

                dir.Create(); //create directory (folder) at path "outFiles"

                string fileName = "Groot.txt";
                f = new FileInfo($"{dirName}/{fileName}");
                f.Create().Close(); /**  always closing stream when done  **/

                //if stream is closed, we can rename the file ( to Rocket.txt)
                f.MoveTo($"{dirName}/Rocket.txt"); //rename (mote to other path)


                //***********************************************
                //					Streams
                //***********************************************
                FileStream stream;

                //Example 4 - crete file at path "outFiles/newFile.txt" and write data into it
                stream = new FileStream($"{dirName}/newFile.Txt", FileMode.OpenOrCreate);
                byte[] fileData = Encoding.ASCII.GetBytes("I am Groot! and Bubu is the king :)");
                stream.Write(fileData, 0, fileData.Length); //write all data content (array of byte)
                stream.Close(); //close - always cleanup after yourself when working with streams!


                //Example 5 - manipulate file data
                stream = new FileStream($"{dirName}/data.txt", FileMode.Open);
                for (int i = 0; i < fileData.Length; i++)
                {
                    int b = fileData[i] + 1; //write every byte as current+1 (a->b, 1->2)
                    stream.WriteByte((byte)b);
                }
                stream.Close(); //always close
                Console.WriteLine("Manipulation Done");

                //Example 6 - Copy
                FileStream inStream = new FileStream("inFiles/Bubu.txt", FileMode.Open); //reading from this 
                FileStream outStream = new FileStream("outFiles/some.txt", FileMode.Create); //write from this 

                int d;
                while ((d = inStream.ReadByte()) != -1) //read 1 byte
                {
                    //as long as inStream has valid data
                    outStream.WriteByte((byte)d); //write 1 byte of data, to some.txt with outStream
                }

                //cleanup
                inStream.Close();
                outStream.Close();


                //Example 7 - Deletion
                string path = "outFiles/Rocket.txt";
                if (File.Exists(path)) File.Delete(path);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }


            //Exercise:
            //write program that enters name and writes it to file
            //then read it and prints.

            try
            {
                string path = "outFiles/exercise.txt";
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                FileStream outStream = new FileStream(path, FileMode.Create);
                byte[] data = Encoding.ASCII.GetBytes(name);
                outStream.Write(data, 0, data.Length);
                outStream.Close(); //cleanup

                string fromFile = File.ReadAllText(path);
                Console.WriteLine($"from file: {fromFile}");
            }
            catch (IOException e)
            {

                throw;
            }
        }
    }
}
