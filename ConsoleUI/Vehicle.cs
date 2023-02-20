using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public int Year { get; set; } = 1;
		public string Make { get; set; } = "Mazda";
		public string Model { get; set; } = "CX5";

		public abstract void DriveAbstract(); //stubbed out method

		public virtual void DriveVirtual()
		{
			Console.WriteLine($"This {GetType().Name} is virtually in drive");
		}
    }
}

