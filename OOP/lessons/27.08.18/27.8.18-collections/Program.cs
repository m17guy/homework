using System;
using System.Collections;
using System.Collections.Generic;

namespace _27._8._18_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            IList somelist; //=interface
            somelist = new ArrayList();//instantiate
            //add is an method in Ilist, it adds the value to the END of the array
            somelist.Add("groot");
            somelist.Add(13);
            somelist.Add(14);
            somelist.Add(15);
            somelist.Add(true);
            somelist.Add("groot");
            somelist.Add('4');
            Console.WriteLine(somelist.Count);//print legth
            Console.WriteLine(somelist[2]);//print val at location
                                           //    somelist.Remove("groot");//will remove the first instence
                                           //or
            for (int i = 0; i < somelist.Count;)
            {
                if (somelist[i] == "groot")//will remove all groot
                {
                    somelist.RemoveAt(i);
                }
                else
                {
                    i++;//importent! if next to one another will it will rimove the next one will change its index and will be skipt
                }
            }
            somelist.RemoveAt(somelist.Count - 1);
            Console.WriteLine(somelist.Count);



            List<string> names = new List<string>();// the same BUT* is generic and has only one value type
            names.Add("hackerU");
            names.Add("bubu");
            names.Add("dor.net");
            foreach (string n in names) Console.WriteLine(n);


            Console.WriteLine("bubu".GetHashCode());
            Console.WriteLine(10.GetHashCode());
            Console.WriteLine('s'.GetHashCode());

            HashSet<object> vals = new HashSet<object>();//all values can only be set once(only in one place)
            vals.Add(10);
            vals.Add("bubu");
            vals.Add(10);
            vals.Add(9);
            vals.Add(5);
            vals.Add(10);
            if (vals.Contains("bubu"))//returns true/fals
                Console.WriteLine("bubu is in");
            foreach (object x in vals) Console.WriteLine(x);

            ISet<int> nums = new SortedSet<int>();//iset is to show the inheretence
            nums.Add(5);
            nums.Add(3);
            nums.Add(4);
            nums.Add(7);
            nums.Add(5);
            nums.Add(5);
            nums.Add(2);
            nums.Add(1);
            foreach (int x in nums) Console.WriteLine(x);




            Dictionary<string, int> grades = new Dictionary<string, int>();
            grades.Add("groot", 70);
            grades.Add("roket", 98);
            grades.Add("starlord", 50);
            //actions on dictionary
            Console.WriteLine(grades["groot"]);//using the key for the location
            grades.Remove("starlord");
            grades["roket"] = 87;//to change values, * an add fnchin will make an error
            Console.WriteLine(grades.Count);
            //iterate over values
            foreach (int gr in grades.Values) Console.WriteLine(gr);
            foreach (string name in grades.Keys) Console.WriteLine(name);
            foreach (KeyValuePair<string, int> x in grades) Console.WriteLine(x.Key+" => "+x.Value);
            //iterate over values by keys
            foreach (string name in grades.Keys) Console.WriteLine(name + "=>" + grades[name]);

            //array to list 
            int[] numbers = { 85, 90, 70 };
            List<int> nNums = new List<int>(numbers);
            //& list to array
            numbers = nNums.ToArray();


            Console.ReadKey();
        }
    }
}
