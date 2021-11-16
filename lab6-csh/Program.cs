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

			/*
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
			*/





			// Лабораторная №7
			//===========================================================================================================

			/*
			Console.Write("Лабраторная 7:\n\n");
			Console.Write("10) Для полей добавить свойства и продемонстрировать работу с ними\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Учитель\n");
			Teacher Oleg = new Teacher();
			Oleg.Fam = "Симонов";
			Oleg.Name = "Олег";
			Oleg.Otch = "Максимович";
			Console.WriteLine("ФИО: " + Oleg.Fam + " " + Oleg.Name + " " + Oleg.Otch);

			Console.Write("\n\n");
			Console.Write("11) Cоздать массив объектов и продемонстрировать работу с ним\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Учитель\n");
			Teacher[] teachs = new Teacher[3];
			for (j = 0; j < 3; j++)
				teachs[j] = new Teacher();

			teachs[0].Set("Иванова", "Марина", "Витальевна");
			teachs[1].Set("Погребнеков", "Николай", "Михайлович");
			teachs[2].Set("Баянова", "Людмила", "Анатольевна");

			Console.Write("Вывод всех учителей:\n");
			for (i = 0; i < 3; i++)
				teachs[i].DisplayInfo();


			Console.Write("\n\n");
			Console.Write("12) В отдельной ветке проекта заменить класс (class) \nна структуру (struct). Продемонстрировать различие \nмежду присваиванием объектов класса и структуры\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Учитель и структуры Оценка\n");
			Mark good = new Mark();
			Teacher Ivan = new Teacher();
			good.Set(4);
			Ivan.Set("Сидоров", "Иван", "Анатольевич");
			Console.WriteLine("Элемент структуры до копирования:");
			good.DisplayValue();
			Console.Write("\n");
			Console.WriteLine("Элемент класса до копирования:");
			Ivan.DisplayInfo();
			Console.Write("\n");
			Console.WriteLine("Элемент структуры копируется на:");
			marks2[0].DisplayValue();
			Console.Write("\n");
			Console.WriteLine("Элемент класса копируется на:");
			Oleg.DisplayInfo();
			Console.Write("\n");
			good = marks2[0];
			Ivan = Oleg;
			Console.WriteLine("Элемент структуры после копирования:");
			good.DisplayValue();
			Console.Write("\n");
			Console.WriteLine("Элемент класса после копирования:");
			Ivan.DisplayInfo();
			Console.Write("\n\n");
			Console.WriteLine("Если изменить те объекты, на которые менялись объект класса и структуры:");
			marks2[0].Set(3);
			Oleg.Set("Погребнеков", "Николай", "Михайлович");
			marks2[0].DisplayValue();
			Oleg.DisplayInfo();
			Console.Write("\n");
			Console.WriteLine("То новые объектыбудут таковыми:");
			good.DisplayValue();
			Ivan.DisplayInfo();
			Console.WriteLine("Объект класса изменился, потому что копируется ссылка \nна объект, а объект структуры не изменился, т.к. \nкопируются значения полей.");
			
			Console.Write("\n\n");
			Console.Write("13) Продемонстрировать работу с массивом объектов\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере структуры Оценка\n");
			Mark[][] marksTest = new Mark[1][];
			marksTest[0] = new Mark[5];
			Console.Write("Массив оценок:\n");
			for (j = 0; j < 5; j++)
			{
				marksTest[0][j].Set(j + 1);
				marksTest[0][j].DisplayValue();
			}

			Console.Write("\n\n");
			Console.Write("14) Продемонстрировать возврат значения через параметр out и через\nпараметр ref. Показать различие этих механизмов\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере структуры оценка\n");
			// Инициализация объектов структуры
			Mark markForRef = new Mark();
			Mark markForOut = new Mark();

			// Инициализация переменной для передачи по ref
			int ArgRef = 2;
			// Описание переменной для передачи по out
			int ArgOut;

			markForRef.Set(1);
			// Передача аргумента по ref
			markForRef.TestRef4(ref ArgRef);
			Console.WriteLine("Аргумент функции после использования по ref: " + ArgRef);

			markForOut.Set(2);
			// Передача аргумента по out
			markForOut.TestOut5(out ArgOut);
			Console.WriteLine("Аргумент функции после использования по out: " + ArgOut);



			Console.Write("\n\n");
			Console.Write("15) Продемонстрировать разумное использование оператора this\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Учитель, двусвязанный список\n\n");

			// Формирование объектов класса Teacher:
			teachers[0].Set("Иванова", "Марина", "Витальевна");
			teachers[1].Set("Погребнеков", "Николай", "Михайлович");
			teachers[2].Set("Баянова", "Людмила", "Анатольевна");

			Teacher.NewList();

			// Вызов статической компанентной функции:
			Teacher.reprint();

			// Включение созданных компанентов в двусвязанный список:
			teachers[0].Add(); teachers[1].Add(); teachers[2].Add();

			// Печать в обратном порядке значений элементов списка:
			Teacher.reprint();



			Console.Write("\n\n");
			Console.Write("16) Продемонстрировать перегрузку операторов '+', '++'\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере структуры Оценка\n");
			Mark mark1 = new Mark();
			Mark mark2 = new Mark();
			Console.Write("Оценка 1 и оценка 2:\n");
			mark1.Set(1);
			mark2.Set(2);
			mark1.DisplayValue();
			mark2.DisplayValue();
			Console.Write("Сумма оценок через оператор \'+\':\n");
			mark1 = mark1 + mark2;
			mark2 = mark1;
			mark1.DisplayValue();
			Console.Write("Прибавление к сумме 1 через постфиксный оператор \'++\': ");
			(mark1++).DisplayValue();
			Console.Write("Прибавление к сумме 1 через префиксный оператор \'++\': ");
			(++mark2).DisplayValue();


			Console.Write("\n\n");
			Console.Write("17) Продемонстрировать обработку строк (string)\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Учитель, добавление ко всем полям пробелов\n");
			teachers[0].AdditionSapces();
			teachers[0].DisplayInfo();

			Console.Write("==================================================================\n");
			//===========================================================================================================
			*/


			// Лабораторная №8
			//===========================================================================================================
			Console.Write("Лабраторная 8:\n\n");
			Console.Write("=========\nМодифицировать ваши проекты на С++, C# и Java путем добавления в один из классов\nкак минимум одного статического поля и одного статического метода.\n=========\n\n");

			Console.Write("(Использовались статический член класса \'lastTeacher\'и\nстатические методы класса \'NewList\' и \'reprint\')\n\n");

			// Формирование объектов класса Teacher:
			teachers[0].Set("Иванова", "Марина", "Витальевна");
			teachers[1].Set("Погребнеков", "Николай", "Михайлович");
			teachers[2].Set("Баянова", "Людмила", "Анатольевна");

			Console.Write("Вызов статической компанентной функции: \'Новый список\'\n\n");
			// Вызов статической компанентной функции:			
			Teacher.NewList();

			Console.Write("Вызов статической компанентной функции: \'Напечатать список\'\n\n");
			// Вызов статической компанентной функции:
			Teacher.reprint();

			Console.Write("\n");

			Console.Write("Добавление элементов в список.\n\n");
			// Включение созданных компанентов в двусвязанный список:
			teachers[0].Add(); teachers[1].Add(); teachers[2].Add();

			Console.Write("Вызов статической компанентной функции: \'Напечатать список\'\n\n");
			Console.Write("===================================\n");
			// Печать в обратном порядке значений элементов списка:
			Teacher.reprint();
			Console.Write("===================================\n");
		}
	}
}
