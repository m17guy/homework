using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allgames = { "1. walking game (simple movement)", "2. shooting game (not ready yet)" };

            Console.WriteLine("enter your player name");
            player guy = new player(Console.ReadLine());
            if (guy.name == "")
            {
                guy.name = "cool cat";
            }
            Console.Clear();
            Console.WriteLine("Ok "+guy.name+", what game would you like to play?");
            foreach(string s in allgames)
            {
                Console.WriteLine(s);
            }
            //switch (Console.ReadLine().ToString())
            switch ("2") //for testing spasific game modes
            {
                case "1":
                    map test = new map();
                    Console.Clear();
                    test.playerenters(guy);
                    test.addgoal();
                    test.printmap();
                    while (test.points < test.wincondishin)
                    {
                        Console.Write("you have " + test.points);
                        Console.WriteLine(test.points == 1 ? " point" : " points");
                        test.moveplayer(test.inme[0], Console.ReadKey());
                        Console.Clear();
                        test.printmap();
                    }
                    Console.WriteLine("you won the game");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("not working yet");

                    map GunRange = new map(21, 21, 10);
                    GunRange.playerenters(guy,true);
                    GunRange.addgoal();
                    GunRange.printmap();
                    while (GunRange.points < GunRange.wincondishin)
                    {
                        Console.Write("youve hit " + GunRange.points);
                        Console.WriteLine(GunRange.points == 1 ? "target" : " targets");
                        GunRange.shoot(guy, Console.ReadKey());
                        Console.Clear();
                        GunRange.printmap();
                    }
                    break;
            }


            Console.ReadKey();
        }
    }
    class map
    {
        public int wincondishin;
        public int points = 0;
        public List<player> inme = new List<player>();
        Random r = new Random();
        public string[,] layuot;
        public map()
        {
            wincondishin = 5;
            int hight = r.Next(10, 20);
            int width = r.Next(12, 25);
            layuot = new string[hight, width];
            makemap();
        }
        public map(int hight, int width, int winamount)
        {
            wincondishin = winamount;
            layuot = new string[hight, width];
            makemap();
        }
        public void printmap()
        {
            for (int i = 0; i < layuot.GetLength(0); i++)
            {
                for (int ii = 0; ii < layuot.GetLength(1); ii++)
                {
                    if (layuot[i, ii] != "*")
                    {
                        switch (layuot[i, ii])
                        {
                            case "$":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "%":
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                        }
                    }
                    Console.Write(layuot[i, ii]+" ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            //Console.WriteLine(layuot.GetLength(0) + " " + layuot.GetLength(1));
        }
        private void makemap()
        {
            for(int i = 0; i < layuot.GetLength(0); i++)
            {
                for (int ii = 0; ii < layuot.GetLength(1); ii++)
                {
                    layuot[i, ii] = "*";
                }
            }
            foreach(player p in inme)
            {
                layuot[p.location[0], p.location[1]] = p.icon.ToString();
            }
        }
        public void playerenters(player gotIn)
        {
            gotIn.location[0] = r.Next(100) > 50 ? layuot.GetLength(0) / 4 : (layuot.GetLength(0) / 2) + (layuot.GetLength(0) / 4);
            gotIn.location[1] = r.Next(100) > 50 ? layuot.GetLength(1) / 4 : (layuot.GetLength(1) / 2) + (layuot.GetLength(1) / 4);
            inme.Add(gotIn);
            updatemap(gotIn.location[0], gotIn.location[1], gotIn.icon.ToString());
        }
        public void playerenters(player gotIn, bool center)
        {
            if (center == false)
            {
                gotIn.location[0] = r.Next(100) > 50 ? layuot.GetLength(0) / 4 : (layuot.GetLength(0) / 2) + (layuot.GetLength(0) / 4);
                gotIn.location[1] = r.Next(100) > 50 ? layuot.GetLength(1) / 4 : (layuot.GetLength(1) / 2) + (layuot.GetLength(1) / 4);
            }
            else
            {
                gotIn.location[0] = (layuot.GetLength(0) / 2);
                gotIn.location[1] = (layuot.GetLength(1) / 2);
            }
            inme.Add(gotIn);
            updatemap(gotIn.location[0], gotIn.location[1], gotIn.icon.ToString());
        }
        public void playerleaves(player leaving)
        {
            inme.Remove(leaving);
            updatemap(leaving.location[0], leaving.location[1], "*");
        }
        public void moveplayer(player p, ConsoleKeyInfo click)
        {
            switch (click.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (inme[inme.IndexOf(p)].location[0] != 0)
                    {
                        if (layuot[p.location[0] - 1, p.location[1]] == "$")
                        {
                            getpoints(1);
                        }
                        if (layuot[p.location[0] - 1, p.location[1]] == "%")
                        {
                            getpoints(3);
                        }
                        updatemap(p.location[0], p.location[1], "*");
                        inme[inme.IndexOf(p)].location[0] -= 1;
                    }
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (inme[inme.IndexOf(p)].location[0] + 1 != layuot.GetLength(0))
                    {
                        if (layuot[p.location[0] + 1, p.location[1]] == "$")
                        {
                            getpoints(1);
                        }
                        if (layuot[p.location[0] + 1, p.location[1]] == "%")
                        {
                            getpoints(3);
                        }
                        updatemap(p.location[0], p.location[1], "*");
                        inme[inme.IndexOf(p)].location[0] += 1;
                    }
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (inme[inme.IndexOf(p)].location[1] != 0)
                    {
                        if (layuot[p.location[0], p.location[1] - 1] == "$")
                        {
                            getpoints(1);
                        }
                        if (layuot[p.location[0], p.location[1] - 1] == "%")
                        {
                            getpoints(3);
                        }
                        updatemap(p.location[0], p.location[1], "*");
                        inme[inme.IndexOf(p)].location[1] -= 1;
                    }
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (inme[inme.IndexOf(p)].location[1] + 1 != layuot.GetLength(1))
                    {
                        if (layuot[p.location[0], p.location[1] + 1] == "$")
                        {
                            getpoints(1);
                        }
                        if (layuot[p.location[0], p.location[1] + 1] == "%")
                        {
                            getpoints(3);
                        }
                        updatemap(p.location[0], p.location[1], "*");
                        inme[inme.IndexOf(p)].location[1] += 1;
                    }
                    break;
            }
            updatemap(p.location[0], p.location[1], p.icon.ToString());
        }
        private void updatemap(int hight, int width, string newchar)
        {
            layuot[hight, width] = newchar;
        }
        public void getpoints(int amount)
        {
            points += amount;
            if (points < wincondishin)
                addgoal();
        }
        public void addgoal()
        {
            if (r.Next(100) < 20)
                layuot[r.Next(1, layuot.GetLength(0) - 1), r.Next(1, layuot.GetLength(1) - 1)] = "%";
            else
                layuot[r.Next(1, layuot.GetLength(0) - 1), r.Next(1, layuot.GetLength(1) - 1)] = "$";
        }
        bullet movingB;
        public void shoot(player p, ConsoleKeyInfo click)
        {
            bullet b;
            switch (click.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    b = new bullet("|", p.location[0] - 1, p.location[1]);
                    //Thread movingbullet = new Thread(() => movebullet(b, "up")); https://stackoverflow.com/questions/1314155/returning-a-value-from-thread
                    while (b!=null)
                    {
                        b = movebullet(b, "up");
                    }
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    b = new bullet("|", p.location[0] + 1, p.location[1]);
                    while (b != null)
                    {
                        b = movebullet(b, "down");
                    }
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    b = new bullet("-", p.location[0], p.location[1] - 1);
                    while (b != null)
                    {
                        b = movebullet(b, "left");
                    }
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    b = new bullet("-", p.location[0], p.location[1] + 1);
                    while (b != null)
                    {
                        b = movebullet(b, "right");
                    }
                    break;
            }
        }
        public bullet movebullet(bullet b,string direction)
        {
            updatemap(b.location[0], b.location[1], b.icon);
            Console.Clear();
            printmap();
            Thread.Sleep(180);
            switch (direction)
            {
                case "up":
                    if (b.location[0] != 0)
                    {
                        if (layuot[b.location[0] - 1, b.location[1]] == "#")
                        {
                            getpoints(1);
                        }
                        updatemap(b.location[0], b.location[1], "*");
                        b.location[0] -= 1;
                    }
                    else
                    {
                        updatemap(b.location[0], b.location[1], "*");
                        return null;
                    }
                    break;
                case "down":
                    if (b.location[0] < layuot.GetLength(0) - 1)
                    {
                        if (layuot[b.location[0] + 1, b.location[1]] == "#")
                        {
                            getpoints(1);
                        }
                        updatemap(b.location[0], b.location[1], "*");
                        b.location[0] += 1;
                    }
                    else
                    {
                        updatemap(b.location[0], b.location[1], "*");
                        return null;
                    }
                    break;
                case "left":
                    if (b.location[1] != 0)
                    {
                        if (layuot[b.location[1], b.location[1] - 1] == "#")
                        {
                            getpoints(1);
                        }
                        updatemap(b.location[0], b.location[1], "*");
                        b.location[1] -= 1;
                    }
                    else
                    {
                        updatemap(b.location[0], b.location[1], "*");
                        return null;
                    }
                    break;
                case "right":
                    if (b.location[1] < layuot.GetLength(1) - 1)
                    {
                        if (layuot[b.location[1], b.location[1] + 1] == "#")
                        {
                            getpoints(1);
                        }
                        updatemap(b.location[0], b.location[1], "*");
                        b.location[1] += 1;
                    }
                    else
                    {
                        updatemap(b.location[0], b.location[1], "*");
                        return null;
                    }
                    break;
            }
            return b;
        }
    }
    class player
    {
        public char icon = '&';
        public int[] location = new int[2];
        public string name;
        public player(string n)
        {
            name = n;
        }
        public void changicon(char newicon)
        {
            if (newicon == '*')
            {
                Console.WriteLine("pleyer cant be same icon as background");
            }
            else
            {
                icon = newicon;
            }
        }
        
    }
    class bullet
    {
        public string icon;
        public int[] location = new int[2];
        public bullet(string Icon, int hight, int width)
        {
            icon = Icon;
            location[0] = hight;
            location[1] = width;
        }
    }
}
