using System;

namespace _26._11._18
{
    class arr
    {
        private string[] names = new string[10];
        public string this[int index]
        {
            get
            {
                if (index > names.Length - 1)
                {
                    Console.WriteLine("the list isnt that long");
                    return null;
                }
                else
                    return names[index];
            }
            set
            {
                if (index > names.Length - 1)
                {
                    string[] temp = names;
                    names = new string[index + 1];
                    for(int i = 0; i < temp.Length; i++)
                    {
                        names[i] = temp[i];
                    }
                    temp = null;
                }
                names[index] = value;
            }
        }
    }
    class complexnum
    {
        double real;
        double imaginary;
        public complexnum(double a, double b)
        {
            real = a;
            imaginary = b;
        }
        public static complexnum operator +(complexnum a, complexnum b)
        {
            return new complexnum(a.real + b.real, a.imaginary + b.imaginary);
        }
        public static complexnum operator -(complexnum a, complexnum b)
        {
            return new complexnum(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static complexnum operator *(complexnum a, complexnum b)
        {
            double r, i;
            r = a.real * b.real - a.imaginary * b.imaginary;
            i = a.real * b.imaginary + a.imaginary * b.real;
            return new complexnum(r,i);
        }
        public override string ToString()
        {
            return $"{real}+{imaginary}i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            arr guys = new arr();
            guys[2] = "guy";
            Console.WriteLine(guys[2]);
            guys[15] = "ruven";
            Console.WriteLine(guys[15]);
            Console.WriteLine(guys[2]);
            Console.WriteLine(guys[10]);



            complexnum a, b;
            a = new complexnum(1.4, 2.6);
            b = new complexnum(0.87, 192.1);
            complexnum c = a + b * b - a * a;

            Console.ReadLine();
        }
    }
}
