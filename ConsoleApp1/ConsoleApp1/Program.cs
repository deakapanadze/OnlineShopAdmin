using System;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{


			int i = 0;
			string s = "108";
			bool result = int.TryParse(s, i);
			
			



			Console.WriteLine(result);	
			
		}
	}
}
