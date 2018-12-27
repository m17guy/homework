using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void printSlow(string text)
		{
			foreach(char c in text)
			{
				Console.Write(c);
				Thread.Sleep(300);
			}
		}
		static void Main(string[] args)
		{
			printSlow("this is it!");
		}
	}
}
