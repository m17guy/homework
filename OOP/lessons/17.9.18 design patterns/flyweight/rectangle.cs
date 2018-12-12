using System;
using System.Collections.Generic;
using System.Text;

namespace flyweight
{
    class rectangle
    {
        //flyweight collection
        private static Dictionary<string, rectangle> cache = new Dictionary<string, rectangle>();
        public static rectangle GetRectangle(string color)
        {
            if (!cache.ContainsKey(color)) cache[color] = new rectangle(color);
            return cache[color];
        }


        //int width, height;
        public string color;

        public static int count = 0;
        public rectangle(string c)
        {
            color = c;
            count++;
        }
        public void draw(int width, int height)
        {
            Console.WriteLine($"color: {color}, width: {width}, height: {height}");
        }
    }
}
