using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_methods
{
    static class myextensions
    {
        public static string makeroyal(this string name)
        {
            return "His majesty " + name;
        }
        public static string censorship(this string sentence)
        {
            string[] nonowords = { "moist", "exobarent", "weeeeet" };
            foreach(string s in nonowords)
            {
                sentence = sentence.Replace(s, "*****");
            }
            return sentence;
        }
        public static int round(this double num)
        {
            return (int)(num+0.5);
        }
    }


    delegate void fight(kid k);
    class kid
    {
        public event fight seekidfight;
        public string name;
        public void iseethekidfighting(fight reaction)
        {
            seekidfight += reaction;
        }
        public void kidfighting()
        {
            seekidfight(this);
        }

    }
    class father
    {
        public void disaplinkid(kid son)
        {
            Console.WriteLine(son.name+" is being spanked");
        }
    }
    class mother
    {
        public void disapointed(kid son)
        {
            Console.WriteLine("im creing becous of " + son.name);
        }
    }
    class councellor
    {
        public void badatjob(kid son)
        {
            Console.WriteLine("im trabled by " + son.name);
        }
    }
    class principal
    {
        public void punishment(kid son)
        {
            Console.WriteLine(son.name + " is being suspended");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guy".makeroyal());
            Console.WriteLine("noy is very moist after an exobarent playdate with guy, so yes she was very weeeeet".censorship());
            Console.WriteLine(3.9.round());


            kid k = new kid { name = "ruven" };
            father f = new father();
            mother m = new mother();
            councellor c = new councellor();
            principal p = new principal();
            k.seekidfight += f.disaplinkid;
            k.seekidfight += m.disapointed;
            k.seekidfight += c.badatjob;
            k.iseethekidfighting(p.punishment);
            k.kidfighting();
        }
    }
}
