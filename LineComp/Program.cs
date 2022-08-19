﻿namespace LineComp
{
	public class Program
	{
		public void CartesianSystem()
		{
			Console.WriteLine("**Welcome to The Line Comparison Computation Program**");

			//Taking Co-ordinates as a variables
			int x1, y1, x2, y2;

			//Taking Inputs from users 
			Console.WriteLine("Enter the value of x1: ");
			x1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of x2: ");
			x2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y1: ");
			y1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y2: ");
			y2 = Convert.ToInt32(Console.ReadLine());

			//Defining the Length of line
			double length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);

			Console.WriteLine("The length of line is: " + length);

		}
		public static void Main(string[] args)
		{
			Program prg = new Program();
			prg.CartesianSystem();
		}

	}

}
