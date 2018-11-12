using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{
			int a=5;
			refExample(ref a);
			int c;
			outExample(out c);
		}

		static void refExample(ref int x)
		{

		}

		static void outExample(out int x)
		{
			x = 10;		
		}
	}
}
