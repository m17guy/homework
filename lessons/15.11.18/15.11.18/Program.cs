using System;

namespace _15._11._18
{
    class Program
    {
        delegate double math(double d, double dd);
        static void Main(string[] args)
        {
            ifly[] all = { new subomb("ahmed"), new plane(), new bird() };
            foreach(ifly f in all)
            {
                Console.WriteLine(f);
                f.fly();
            }


            math m = add;
            Console.WriteLine(x4(1, 1, m, sub));
            Console.ReadLine();
        }
        static double add(double a,double b)
        {
            return a + b;
        }
        static double sub(double a, double b)
        {
            return a - b;
        }
        static double mul(double a, double b)
        {
            return a * b;
        }
        static double x4(double a,double b, math c, math d)
        {
            return c(a, b) + d(a, b);
        }
    }
    interface ifly
    {
        void fly();
    }
    class person
    {
        public person(string n)
        {
            name = n;
        }
        public string name
        {
            get; set;
        }
        public override string ToString()
        {
            return name;
        }
    }
    class subomb : person, ifly
    {
        public subomb(string n) : base(n)
        {
        }

        public void fly()
        {
            Console.WriteLine("the ting gos skkkkra");
        }
    }
    abstract class vihicle
    {
        public vihicle()
        {
        }
        public override string ToString()
        {
            return "I take you places";
        }
    }
    class plane : vihicle, ifly
    {
        public void fly()
        {
            Console.WriteLine("its taking off");
        }
    }
    abstract class animal
    {
        public animal()
        {
        }
        public override string ToString()
        {
            return "I am an animal";
        }
    }
    class bird : animal, ifly
    {
        public void fly()
        {
            Console.WriteLine("look mom im flying");
        }
    }
}
