using System;

namespace carpet_calculator
{
	class MainClass
	{
		/*
		 * Write a program that asks the user for the length and width of their room. Define a constant
         * that represents the price of carpeting per square foot. Compute and display the cost of carpeting the room.
         */

		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the information to find out how much it will cost to carpet your room \n");

			Console.WriteLine("Enter the length of your room");
			int len = int.Parse(Console.ReadLine());

			Console.WriteLine(" \n Enter the width of your room");
			int wid = int.Parse(Console.ReadLine());

			double area = len * wid;

			double carpetPrice = 1.25 * area;


			Console.WriteLine("The area you need carpeted is {0} and it will cost {1:c}", area, carpetPrice);

		}
	}
}
