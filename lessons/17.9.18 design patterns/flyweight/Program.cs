using System;

namespace flyweight
{
    class Program
    {
        static string[] colors = { "green", "red", "blue" };
        static void Main(string[] args)
        {
            
            for(int i = 0; i < 20_000; i++)
            {
                string color = colors[i % 3];
                rectangle rec = rectangle.GetRectangle(color);
                rec.draw(70, 63);
            }
            Console.WriteLine(rectangle.count);



            rectangle flyweight = new rectangle(colors[0]);
            flyweight.draw(5, 3);
            flyweight.draw(70, 63);
            flyweight.draw(14, 35);





            //****************************************
            image ing1 = imagefactory.GetImage("123");
            image ing2 = imagefactory.GetImage("234");
            image ing3 = imagefactory.GetImage("345");
            image ing4 = imagefactory.GetImage("456");
            ing1.show();
            ing2.show();
            ing3.show();
            ing4.show();

            Console.ReadKey();
        }
    }
}
