using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_collection
{
    class newset
    {
        public HashSet<int> nums = new HashSet<int>();
        public void add(int a)
        {
            bool lastnum = false;
            if (a == -1)
            {
                lastnum = true;
                nums.Add(a);
            }
            if (!lastnum)
                nums.Add(a);
            else
                Console.WriteLine("set is closed");
        }
        public void printeven()
        {
            int count = 0;
            foreach(int e in nums)
            {
                if (e % 0 == 0)
                    count++;
            }
            Console.WriteLine("even numbers in the set: "+count);
        }
    }
}
