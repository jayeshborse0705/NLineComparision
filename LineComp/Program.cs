namespace LineComp
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

			//Taking Co-ordinates as a variables for Line 2
			int x3, y3, x4, y4;

			//Taking Inputs from users for line 2
			Console.WriteLine("**Computation for line 2**");

			Console.WriteLine("Enter the value of x3: ");
			x3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of x4: ");
			x4 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y3: ");
			y3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y4: ");
			y4 = Convert.ToInt32(Console.ReadLine());

			//Defining the Length of line
			double length2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);

			Console.WriteLine("The length of line2 is: " + length2);

			//comparing the lengths of lines 1 & 2
			if (length == length2)
			{
				Console.WriteLine("The given lines are equals: ");
			}
			else
			{
				Console.WriteLine("The given lines are not equal: ");

			}


		}
		public static void Main(string[] args)
		{
			Program prg = new Program();
			prg.CartesianSystem();
		}

	}

}