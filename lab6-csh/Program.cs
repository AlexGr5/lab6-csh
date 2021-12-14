using System;

namespace lab6_csh
{
    class Program
    {
        static void Main(string[] args)
        {

			Mark[] mark1 = new Mark[3]; Mark [,] mark2 = new Mark[2,2];

			mark1[0] = new Mark();
			mark1[1] = new Mark();
			mark1[2] = new Mark();

			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 2; j++)
					mark2[i, j] = new Mark();


			// Присваивание
			//=================================
			mark1[0].Set(3);
			mark1[1].Set(4);
			mark1[2].Set(5);

			int bases = 4;

			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 2; j++)
					mark2[i,j].Set(bases + j);
			//=================================

			// Вывод
			//=================================
			Console.WriteLine("Одномерный массив размером [3]");
			for (int i = 0; i < 3; i++)
				mark1[i].DisplayValue();

			Console.WriteLine();

			Console.WriteLine("Двумерный массив размером [2][2]");
			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 2; j++)
					mark2[i,j].DisplayValue();
			//=================================

		}
	}
}
