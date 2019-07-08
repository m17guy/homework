using System;
using System.Collections.Generic;

namespace binerytree
{
    class Program
    {
        static void Main(string[] args)
        {
            bitree tree = new bitree(new node { id = 5 });
            Random r = new Random();
            List<int> allnums = new List<int>();
            int goingin;
            for (int i = 0; i < 10; i++)
            {
                goingin = r.Next(50);
                if (!tree.find(goingin))
                {
                    tree.addon(new node { id = goingin });
                    allnums.Add(goingin);
                }
            }
            tree.print();
            Console.WriteLine("_________________________________");
            allnums.Sort();
            foreach (int i in allnums)
            {
                Console.WriteLine(i);
            }
        }
    }
    class node
    {
        public int id;
        public node left;
        public node right;
        public node perent;
    }
    class bitree
    {
        public node head;
        public bitree(node headnode)
        {
            head = headnode;
        }
        public string addon(node n)
        {
            if (this.find(n.id))
            {
                return "node is already in the tree";
            }
            node temp = head;
            while (true)
            {
                if (temp.id > n.id) //smaller on the left
                {
                    if (checkside(temp, "l"))
                    {
                        temp = temp.left;
                    }
                    else
                    {
                        n.perent = temp;
                        temp.left = n;
                        return "the node has been added";
                    }
                }
                else //biger on the right
                {
                    if (checkside(temp, "r"))
                    {
                        temp = temp.right;
                    }
                    else
                    {
                        n.perent = temp;
                        temp.right = n;
                        return "the node has been added";
                    }
                }
            }
            return "error: not added";
        }
        public bool find(int id)
        {
            node temp= head;
            while(true)
            {
                if (temp.id == id)
                {
                    return true;
                }
                if (temp.id > id) //smaller on the left
                {
                    if (checkside(temp, "l"))
                    {
                        temp = temp.left;
                    }
                    else
                    {
                        break;
                    }
                }
                else //biger on the right
                {
                    if (checkside(temp, "r"))
                    {
                        temp = temp.right;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return false;
        }
        public bool checkside(node n, string side)
        {
            if (side == "r" || side == "right")
            {
                if (n.right != null)
                    return true;
            }
            if (side == "l" || side == "left")
            {
                if (n.left != null)
                    return true;
            }
            return false;
        }
        public void print()
        {
            node temp = head;
            int lastprinted;
            while (true)
            {
                while (temp.left != null)
                {
                    temp = temp.left;
                }
                Console.WriteLine(lastprinted = temp.id);
                if (temp.right != null)
                {
                    temp = temp.right; //going to a higher number WITHOUT going up
                }
                //i CAN'T put thing after the else becouse i need it to go left all the way down again
                else
                {
                    while (temp.right == null)
                    {
                        temp = temp.perent; //going up a step
                        while (temp.id < lastprinted) //going up antil biger then last prented
                        {
                            if (temp.perent == null)
                            {
                                return;
                            }
                            temp = temp.perent;
                        }
                        Console.WriteLine(lastprinted = temp.id);
                    }
                    temp = temp.right;
                }

            }
        }
        public void recunstroct()
        {
            List<int> alldata = new List<int>();
            node temp = head;
            int lastprinted;
            bool end = true;
            while (end)
            {
                while (temp.left != null)
                {
                    temp = temp.left;
                }
                alldata.Add(lastprinted = temp.id);
                if (temp.right != null)
                {
                    temp = temp.right; //going to a higher number WITHOUT going up
                }
                //i CAN'T put thing after the else becouse i need it to go left all the way down again
                else
                {
                    while (temp.right == null)
                    {
                        temp = temp.perent; //going up a step
                        while (temp.id < lastprinted) //going up antil biger then last prented
                        {
                            if (temp.perent == null)
                            {
                                end = false;
                                break;
                            }
                            temp = temp.perent;
                        }
                        alldata.Add(lastprinted = temp.id);
                    }
                    temp = temp.right;
                }
            }

            temp = new node { id = alldata[alldata.Count / 2] };
        }
    }
}
