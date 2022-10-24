using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<BMI> studentlist = new List<BMI>()
			{
				new BMI {Height=170, Weight=60},
				new BMI {Height=190, Weight=80},
				new BMI {Height=150, Weight=40},
			};

			Console.WriteLine(studentlist[0].CalculateBMI(studentlist[0].Height, studentlist[0].Weight));
			Console.WriteLine(studentlist[0].CalculateBMI(studentlist[1].Height, studentlist[1].Weight));
			Console.WriteLine(studentlist[0].CalculateBMI(studentlist[2].Height, studentlist[2].Weight));
		}
	}

	class BMI
	{
		public double Height { get; set; }
		public double Weight { get; set; }

		public string CalculateBMI(double height, double weight)
		{
			Height = height;
			Weight = weight;
			double bmi = Weight / ((Height / 100) * (Height / 100));
			string result = bmi.ToString("#0.00");
			return result;
		}
	}
}

