using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamda_practis
{
    class Program
    {
        //simple examples
        delegate void func();
        delegate double otherfunc(double x);
        delegate string stringfunc(string x, string y);
        static void Main(string[] args)
        {
            func myfunc =  () => { Console.WriteLine("wow!"); };
            otherfunc funcy = x => x * x;
            stringfunc sfunc = (x, y) => { Console.WriteLine("fdfd"); return x + y; };


            //ex 1
            string[] names = { "guy", "ruven", "shimshon", "noy", "shimshon" };
            var newnames = names.Select( name => { if (name == "shimshon") name = "no name"; return name; });
            foreach (var x in newnames)
            {
                Console.WriteLine(x);
            }


            //ex 2
            double[] nums = { 1.3, 8.7, 9.4, 5.5 };
            var newnums = nums.Select(number => (int)(number + 0.5));
            foreach (var x in newnums)
            {
                Console.WriteLine(x);
            }

            //ex 3
            var custumers = new[] { new { name = "guy", age = 22, hight = 1.78 }, new { name = "noy", age = 21, hight = 1.60 }, new { name = "ruven", age = 20, hight = 1.55 } };
            var onlynamesandage = custumers.Select(x => new { name = x.name, age = x.age });
            foreach (var person in onlynamesandage)
            {
                Console.WriteLine(person.name+" is "+person.age+" years old");
            }

            //ex 4
            int[] mynums = { 1, 2, 3, 5, 8, 13, 21, 33, 54, 87, 55, 70 };
            var mysqurs = mynums.Where(x => x % 5 == 0).Select(x=>x*x);
            foreach (var num in mysqurs)
            {
                Console.WriteLine(num);
            }

            //ex 5
            string[] numname = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int[] allnums = new int[101];
            for (int i = 0; i < 101; i++)
            {
                allnums[i] = i;
            }
            foreach (var name in allnums.Where(x => x < 10).Select(x => numname[x]))
            {
                Console.WriteLine(name);
            }

            //ex 6
            var animals = new[] { new { tybe = "dog", name = "mo", age = 8, wight = 25 }, new { tybe = "cat", name = "shit face",
                age = 3, wight = 8 }, new { tybe = "dog", name = "dvash", age = 18, wight = 55 }, new { tybe = "dog", name = "my man", age = 5, wight = 40 }, };
            foreach (var pet in animals.Where(anim => anim.tybe == "dog").OrderBy(pet => pet.wight))
            {
                Console.WriteLine($"{pet.name} is {pet.age} years old");
            }
        }
    }
}
