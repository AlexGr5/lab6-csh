using System;

namespace lab6_csh
{
    class Program
    {
        static void Main(string[] args)
        {

			Mark mark1 = new Mark();

			Console.WriteLine("Лабораторная 10\n");
			Console.WriteLine("Введите оценку - число в пределах от 1 до 5!\n");

			while (mark1.Get() == 0)
			{
				mark1.InpMark();
			}

			Console.WriteLine("Введенная оценка: " + mark1.Get());

		}
	}
}
