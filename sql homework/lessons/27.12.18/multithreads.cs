����� ������ ������ (���� ���� �����) ��� 10 thread�� ��� ��� ���
���� �-10 ��� 0 ������� �� 200 ���������.
�� ������ �� �� ������ ��� ����� ����� ����.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	/*
	 * ����� ������ ������ (���� ���� �����) ��� 10 thread�� ��� ��� ���
���� �-10 ��� 0 ������� �� 200 ���������.
�� ������ �� �� ������ ��� ����� ����� ����.
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
