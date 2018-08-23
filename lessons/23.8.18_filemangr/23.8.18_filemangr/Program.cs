using System;

namespace _23._8._18_filemangr
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory librery = new Directory("gamesplace", 4);
            librery.files[0] = new exe("Duel", 4);
            librery.files[3] = new image("duel icon", 4);
            librery.files[2] = new textfile("dule", 4);
            librery.files[1] = new zipfile("data file", 4);
            librery.open();
            Console.ReadKey();
        }
    }
}
