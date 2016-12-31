using System;

class Program
{
	static void Main()
	{
		var numb = new int[8];
		int[] denom = { 2, 0, 4, 4, 0, 8 };
		for (int i = 2; i < 10; i++)
		{
			numb[i - 2] = (int)Math.Pow(2.0, i);
		}
		try
		{
			for (int i = 0; i < numb.Length; i++)
			{
				try
				{
					Console.WriteLine(numb[i] + " / " + denom[i] + " is\t" + numb[i] / denom[i]);
				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("div by zero");
				}
			}
		}
		catch (IndexOutOfRangeException)
		{
			Console.WriteLine("Index out range");
		}

	}
}