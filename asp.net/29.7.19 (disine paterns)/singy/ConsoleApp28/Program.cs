using System;
using System.Threading;

namespace ConsoleApp28
{
	class Program
	{
		static God[] elilim = new God[10];
		static void Main(string[] args)
		{
			for (int i = 0; i < 100; i++)
				new Thread(OvdeyElilim).Start();

		}
		static void OvdeyElilim()
		{
			int index = new Random().Next(10);
			elilim[index] = God.GetGod();
		}
	}

	class God
	{
		private static object forLocking = new object();
		private string traits;
		private God() {
			traits = "merciful";
		}
		private static God theOneAndOnly=null;
		public static God GetGod()
		{
			
			lock (God.forLocking)
			{
				if (theOneAndOnly == null)
					theOneAndOnly = new God();
			}
			return God.theOneAndOnly;
		}
		public override string ToString()
		{
			return "God is " + traits;
		}
	}
}
