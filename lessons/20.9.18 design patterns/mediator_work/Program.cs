using System;

namespace mediator_work
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            cntlTower cTower = new cntlTower();
            airCraft jumbo = new airCraft(cTower, "jumbo");
            airCraft f15 = new airCraft(cTower, "f15");
            airCraft f35 = new airCraft(cTower, "f35");
            jumbo.send("hello");
            airCraft stealth = new airCraft(cTower, "incog");
            stealth.send("i am groot");
            */
            teamComm alfa = new teamComm();
            soldier guy = new soldier(alfa, "guy");
            soldier noy = new soldier(alfa, "noy");
            soldier ruven = new soldier(alfa, "ruven");
            guy.send("you gay");
            soldier tamar = new soldier(alfa, "tamar");
            ruven.send("no you");
            noy.attack();

            Console.ReadKey();
        }
    }
}
