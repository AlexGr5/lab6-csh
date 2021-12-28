using System;

namespace lab6_csh
{
    class Program
    {
        static void Main(string[] args)
        {

            Mark<int> [] MarksInt = new Mark<int>[5];
            Mark<double>[] MarksDouble = new Mark<double>[5];

            for (int i = 0; i < 5; i++)
            {
                MarksInt[i] = new Mark<int>();
                MarksInt[i].Set(i);
                MarksDouble[i] = new Mark<double>();
                MarksDouble[i].Set((i + 0.4));
            }

            Console.WriteLine("\nМассив Оценок с целыми значениями\n");
            for (int i = 0; i < 5; i++)
            {
                MarksInt[i].DisplayValue();
            }

            Console.WriteLine("\nМассив Оценок с нецелыми значениями\n");
            for (int i = 0; i < 5; i++)
            {
                MarksDouble[i].DisplayValue();
            }


        }
	}
}
