using System;

namespace lab6_csh
{
    class Program
    {
        static void Main(string[] args)
        {

			// Создание обЪектов классов
			//----------------------------------
			Teacher[] teachers = new Teacher[3];
			Lesson[] lessons = new Lesson[3];
			Mark[] marks1 = new Mark[3];
			Mark[] marks2 = new Mark[3];
			Mark[] marks3 = new Mark[3];
			Student[] students = new Student[3];
			MyClass classNum1 = new MyClass();
			//----------------------------------

			// Инициализация полей объектов классов
			//---------------------------------------------------------------------------------
			int j = 0;
			for (j = 0; j < 3; j++)
				teachers[j] = new Teacher();

			teachers[0].Set("Иванова", "Марина", "Витальевна");
			teachers[1].Set("Погребнеков", "Николай", "Михайлович");
			teachers[2].Set("Баянова", "Людмила", "Анатольевна");

			for (j = 0; j < 3; j++)
				lessons[j] = new Lesson();
			lessons[0].Set("Химия", teachers[0]);
			lessons[1].Set("Обществознание", teachers[1]);
			lessons[2].Set("Математика", teachers[2]);

			for (j = 0; j < 3; j++)
			{
				marks1[j] = new Mark();
				marks2[j] = new Mark();
				marks3[j] = new Mark();
			}
			marks1[0].Set(4);
			marks1[1].Set(4);
			marks1[2].Set(4);
			marks2[0].Set(5);
			marks2[1].Set(4);
			marks2[2].Set(5);
			marks3[0].Set(5);
			marks3[1].Set(5);
			marks3[2].Set(5);

			for (j = 0; j < 3; j++)
				students[j] = new Student();
			students[0].Set("Сидоров", "Антон", "Витальевич", marks1, 3, lessons, 3);
			students[1].Set("Герасимов", "Владимир", "Анатольевич", marks2, 3, lessons, 3);
			students[2].Set("Иванов", "Николай", "Львович", marks3, 3, lessons, 3);

			classNum1.Set("2В", "2010", students, 3);
			//----------------------------------------------------------------------------------

			Teacher teacher1 = new Teacher();
			Teacher teacher2 = new Teacher("Погребнеков");
			Teacher teacher3 = new Teacher("Баянова", "Людмила", "Анатольевна");

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Console.WriteLine("Конструкторы класса Учитель:");
			Console.WriteLine("1) Конструктор без параметров:");
			teacher1.DisplayInfo();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			teacher2.DisplayInfo();
			Console.WriteLine("3) Конструктор с параметрами:");
			teacher3.DisplayInfo();
			Console.WriteLine("\n\n");


			Lesson lesson1 = new Lesson();
			Lesson lesson2 = new Lesson("Обществознание");
			Lesson lesson3 = new Lesson("Математика", teachers[2]);

			Console.WriteLine("Конструкторы класса Урок:");
			Console.WriteLine("1) Конструктор без параметров:");
			lesson1.DisplayInfo();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			lesson2.DisplayInfo();
			Console.WriteLine("3) Конструктор с параметрами:");
			lesson3.DisplayInfo();
			Console.WriteLine("\n\n");



			Mark markParamLess, markParam(3);

			Console.WriteLine("Конструкторы класса Оценка:");
			Console.WriteLine("1) Конструктор без параметров:");
			markParamLess.DisplayValue();
			Console.WriteLine("2) Конструктор с 1-им параметром, он же с параметрами:");
			markParam.DisplayValue();
			Console.WriteLine("\n\n");



			Student uchenik1, uchenik2("Герасимов"), uchenik3("Герасимов", "Владимир", "Анатольевич", marks2, 3, lessons, 3);
			Console.WriteLine("Конструкторы класса Ученик:");
			Console.WriteLine("1) Конструктор без параметров:");
			uchenik1.DisplayShortInfo();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			uchenik2.DisplayShortInfo();
			Console.WriteLine("3) Конструктор с параметрами:");
			uchenik3.DisplayShortInfo();
			Console.WriteLine("\n\n");

			MyClass class1, class2("5А"), class3("2В", "2010", students, 3);
			Console.WriteLine("Конструкторы класса Мой Класс:");
			Console.WriteLine("1) Конструктор без параметров:");
			class1.DisplayShortInfo();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			class2.DisplayShortInfo();
			Console.WriteLine("3) Конструктор с параметрами:");
			class3.DisplayShortInfo();
			Console.WriteLine("\n\n");
		}
	}
}
