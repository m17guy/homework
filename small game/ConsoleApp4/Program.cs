using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            map test = new map();
            player guy = new player("g money");
            test.playerenters(guy);
            test.addgoal();
            while (test.points<5)
            {
                Console.Clear();
                test.printmap();
                Console.WriteLine(test.points);
                test.moveplayer(test.inme[0], Console.ReadKey());
            }
            Console.WriteLine("you won the game");
            Console.ReadKey();
            
        }
    }
    class map
    {
        public int points = 0;
        public List<player> inme = new List<player>();
        Random r = new Random();
        string[,] layuot;
        public map()
        {
            int hight = r.Next(8, 20);
            int width = r.Next(10, 25);
            layuot = new string[hight, width];
            makemap();
        }
        public map(int hight, int width)
        {
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
            gotIn.location[0] = 0;
            gotIn.location[1] = 0;
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
            addgoal();
        }
        public void addgoal()
        {
            layuot[r.Next(layuot.GetLength(0) - 1), r.Next(layuot.GetLength(1) - 1)] = "$";
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
}
