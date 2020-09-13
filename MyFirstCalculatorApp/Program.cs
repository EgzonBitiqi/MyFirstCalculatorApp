using System;

namespace MyFirstCalculatorApp
{
	class Program
	{
		static void Main(string[] args)
		{
			string repeat = "yes";
			while (repeat == "yes")
			{
				double firstnumber = 0;
				double secondnumber = 0;
				Console.WriteLine("--------------------\n-----Calculator-----\n--------------------");
				Console.WriteLine("\nEnter your first number");
				firstnumber = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("\nEnter your second number");
				secondnumber = Convert.ToDouble(Console.ReadLine());
				Console.Write("\nChoose an option\t\n1.Addition\t\n2.Subtraction\t\n3.Multiplication\t\n4.Division\n");
				Console.Write("Your option is: ");

				switch (Console.ReadLine())
				{
					case "1":
						Console.WriteLine($"\nResult is: {firstnumber} + {secondnumber} = " + (firstnumber + secondnumber));
						break;
					case "2":
						Console.WriteLine($"\nResult is: {firstnumber} - {secondnumber} = " + (firstnumber - secondnumber));
						break;
					case "3":
						Console.WriteLine($"\nResult is: {firstnumber} * {secondnumber} = " + (firstnumber * secondnumber));
						break;

					case "4":
						while (secondnumber == 0)
						{
							Console.WriteLine("Enter a non-zero divisor: ");
							secondnumber = Convert.ToInt32(Console.ReadLine());
						}
						Console.WriteLine($"\nResult is: {firstnumber} / {secondnumber} = " + (firstnumber / secondnumber));
						break;										
				}
				Console.WriteLine("\nWould you like to make another calculation [yes/no]");
				repeat = Console.ReadLine();
				Console.Clear();
			}
		}
	}
}