using System;
using System.Collections.Generic;

namespace binerytree
{
    class Program
    {
        static void Main(string[] args)
        {
            bitree tree = new bitree();
            tree.mytree.Add(new node { id = 5 });
            tree.mytree[0].left = new node { id = 1, perent = tree.mytree[0] };
            tree.mytree[0].right = new node { id = 7, perent = tree.mytree[0] };
            Console.WriteLine(tree.addon(new node { id = 8 }));
            Console.WriteLine(tree.addon(new node { id = 99 }));
            Console.WriteLine(tree.mytree[0].right.right.perent.id);
        }
    }
    class node
    {
        public int id;
        //public bool printed;
        public node left;
        public node right;
        public node perent;
    }
    class bitree
    {
        //public node head;
        public List<node> mytree = new List<node>();
        public string addon(node n)
        {
            if (this.find(n.id))
            {
                return "node is already in the tree";
            }
            node temp = mytree[0];
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
            node temp= mytree[0];
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
            node temp = mytree[0];
            while (temp.left!=null)
            {
                temp = temp.left;
            }// temp is now most left so it is smallest
            
            node steps = mytree[0];
            while (true)
            {
                if (temp.id == steps.id)
                {
                    Console.WriteLine(temp.id);
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
    }
}
