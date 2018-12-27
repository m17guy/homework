כיתבו תוכנית שיוצרת (מלבד הפרד הראשי) עוד 10 threadים שכל אחד מהם
סופר מ-10 ועד 0 בהפרשים של 200 מילישניות.
יש להתחיל את כל הפרדים כמה שאפשר באופן סמוך.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	/*
	 * כיתבו תוכנית שיוצרת (מלבד הפרד הראשי) עוד 10 threadים שכל אחד מהם
סופר מ-10 ועד 0 בהפרשים של 200 מילישניות.
יש להתחיל את כל הפרדים כמה שאפשר באופן סמוך.
*/
	class Program
	{
		static void threadFunc()
		{
			for(int i=10;i>=0;i--)
			{
				Console.WriteLine(Thread.CurrentThread.Name + " says " + i);
				Thread.Sleep(200);
			}
		}

		static void Main(string[] args)
		{
			Thread[] threads = new Thread[10];
			for(int i=0;i<10;i++)
			{
				threads[i] = new Thread(threadFunc);
				threads[i].Name = "Thread" + i;
				
			}
			foreach(Thread thread in threads)
			{
				thread.Start();
			}
		}
	}
}
