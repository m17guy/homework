using System;

namespace ConsoleApp30
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			BneiBrakPizza.PizzaBuilder pizzaBuilder = new BneiBrakPizza.PizzaBuilder();
			pizzaBuilder.setPapperony(true);
			pizzaBuilder.setRealCheese(false);
			pizzaBuilder.build().eat();
		}
	}

	class BneiBrakPizza
	{
		private bool WithRealCheese { get; set; }
		private bool WithPapperony { get; set; }
		private BneiBrakPizza() { }
		public class PizzaBuilder
		{
			bool papperony;
			bool cheese;
			public void setPapperony(bool with)
			{
				papperony = with;
			}
			public void setRealCheese(bool with)
			{
				cheese = with;
			}
			public BneiBrakPizza build()
			{
				if (papperony && cheese)
					return null;
				return new BneiBrakPizza { WithPapperony = papperony, WithRealCheese = cheese };
			}
		}
		public void eat()
		{
			Console.WriteLine("me gusta...");

		}

	}
}
