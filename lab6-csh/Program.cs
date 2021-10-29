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

			int i = 0;

			// Вывод всех данных на экран:
			//----------------------------------------------------------------------------------

			Console.Write("Вывод всех учителей:");
			for (i = 0; i < 3; i++)
				teachers[i].DisplayInfo();

			Console.Write("\n\n");

			Console.Write("Вывод всех уроков:");
			for (i = 0; i < 3; i++)
				lessons[i].DisplayInfo();

			Console.Write("\n\n");

			Console.Write("Вывод всех учеников:");
			for (i = 0; i < 3; i++)
				students[i].DisplayShortInfo();

			Console.Write("\n\n");

			Console.Write("Вывод Класса учеников:");
			classNum1.DisplayShortInfo();

			//----------------------------------------------------------------------------------

			Console.Write("\n\n");

			// Лучшие и хучшие ученики в классе
			//----------------------------------------------------------------------------------
			Console.Write("*******Функция поиска лучших учеников в классе*********\n");
			Console.Write("Лучшие ученики класса №1:");
			classNum1.BestStud();
			Console.Write("***************************************************\n");

			Console.Write("\n\n");

			Console.Write("*******Функция поиска худших учеников в классе********\n");
			Console.Write("Худшие ученики класса №1:");
			classNum1.BedStud();
			Console.Write("***************************************************\n");
			//----------------------------------------------------------------------------------

			Console.Write("\n\n");

			//Console.Write("Тест ввода русских символов на примере ввода учителя:" + "\n");
			//teachers[0].InpFIO();
			//teachers[0].DisplayInfo();

			Console.Write("Лабраторная 7:\n\n");
			Console.Write("10) Для полей добавить свойства и продемонстрировать работу с ними\n");
			Console.Write("==================================================================\n");
			Teacher Oleg = new Teacher();
			Oleg.Fam = "Симонов";
			Oleg.Name = "Олег";
			Oleg.Otch = "Максимович";
			Console.WriteLine("ФИО: " + Oleg.Fam + " " + Oleg.Name + " " + Oleg.Otch);

			Console.Write("\n\n");

		}
    }
}
