using System;
using System.Collections.Generic;

namespace binerytree
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class node
    {
        public int id;
        public bool printed;
        public node left;
        public node right;
    }
    class bitree
    {
        public List<node> mytree = new List<node>();
        public void add(node n)
        {
            
        }
        public bool find(int id)
        {
            node temp;
            if (mytree[0].id > id) //smaller on the left
            {
                temp = mytree[0].left;
            }
            do
            {
                if (mytree[counter].id > id)
                {
                    counter=
                }
                else
                {
                    if
                }
            }
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

        }
    }
}
