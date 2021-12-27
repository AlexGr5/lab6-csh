using System;

namespace lab6_csh
{
    class Program
    {
        static void Main(string[] args)
        {

			//Teacher teacher1 = new Teacher("Иванова", "Марина", "Витальевна");
			//Persone persone1 = new Persone("Погребнеков", "Николай", "Михайлович");

			/*
			Console.WriteLine("3) Продемонстрировать перегрузку метода базового");
			Console.WriteLine("  класса в производном классе(с вызовом метода базового");
			Console.WriteLine("  класса и без такого вызова)\n");

			persone1.DisplayInfo();
			teacher1.DisplayInfo();
			Console.WriteLine();
			persone1.SayHello();
			teacher1.SayHello();
			Console.WriteLine(persone1.WhoIs());
			Console.WriteLine(teacher1.WhoIs());
			*/

			/*
			Console.WriteLine("7) Придумать разумное использование виртуальных функций и создать их в вашем проекте.\n");

			persone1.DisplayInfo();
			teacher1.DisplayInfo();
			Console.WriteLine();
			persone1.SayHello();
			teacher1.SayHello();

			Persone Person = new Persone("Сидоров", "Анатолий", "Михайлович");
			Teacher Teach = new Teacher("Смирнов", "Владимир", "Васильевич");
			Persone pPerson = Teach;
			Teacher pTeach = Teach;
			Persone pPerson2 = Person;

			Console.WriteLine("========================================================");
			Console.WriteLine();
			Console.WriteLine("Объект класса Учитель");
			Teach.DisplayInfo();
			Console.WriteLine();
			Console.WriteLine("Указатель класса Персона на класс Учитель");
			pPerson.DisplayInfo();
			Console.WriteLine();
			Console.WriteLine("Указатель класса Персона на класс Учитель");
			pPerson2.DisplayInfo();
			Console.WriteLine();
			Console.WriteLine("Вызов виртуальной функции через не виртуальную базового класса");
			Console.WriteLine("от объекта класса Учитель");
			Teach.SayHello();
			Console.WriteLine();
			Console.WriteLine("Вызов виртуальной функции через не виртуальную базового класса");
			Console.WriteLine("от объекта класса Персона");
			Person.SayHello();
			Console.WriteLine();
			Console.WriteLine("от указателя Персона на объект класса Учитель");
			Console.WriteLine(pPerson.WhoIs());
			Console.WriteLine();
			Console.WriteLine("от указателя Персона на объект класса Персона");
			Console.WriteLine(pPerson2.WhoIs());
			Console.WriteLine();
			Console.WriteLine("от указателя Учитель на объект класса Учитель");
			Console.WriteLine(pTeach.WhoIs());
			*/


			//Console.WriteLine("8) В проектах на C++,  Java, C# придумать разумное использовани\nабстрактного класса и создать его. Продемонстрировать его использование;\n");
			//teacher1.InpFIO();
			//Console.WriteLine();
			//teacher1.DisplayInfo();

			//Console.WriteLine("6) Заменить методы Display используя операции << для C++\n");
			//Console.WriteLine("ФИО учителя: " + teacher1.ToString());

			/*
			Teacher teacher1 = new Teacher();
			Student student1 = new Student();

			Console.WriteLine("9) В  проектах Java, C# придумать разумное использование интерфейсов.\nПродемонстрировать их использование\n");

			teacher1.InpFIO();
			Console.WriteLine();
			student1.InpFIO();
			Console.WriteLine();

			teacher1.DisplayInfo();
			student1.DisplayInfo();

			Console.WriteLine();

			Console.WriteLine(teacher1.WhoIs());
			Console.WriteLine(student1.WhoIs());
			*/

			Console.WriteLine("10) Продемонстрировать различие между мелким и глубоким копированием:");
			Teacher teacher1 = new Teacher("Погребников", "Николай", "Михайлович");
			Teacher teacher2 = new Teacher("Иванова", "Марина", "Витальевна");

			//markTestCopy2 = markTestCopy1.ShallowCopy();
			teacher2 = teacher1;

			Console.WriteLine("Поверхностная копия 1-го объекта во 2-ой:");
			teacher1.DisplayInfo();
			teacher2.DisplayInfo();
			Console.WriteLine("");
			Console.WriteLine("Изменение 1-го объекта, а 2-ой не трогается:");
			teacher1.Set("Погребников", "Николай", "Михайлович");
			teacher1.DisplayInfo();
			teacher2.DisplayInfo();
			Console.WriteLine("");

			teacher1.Set("Герасимов", "Владимр", "Дмитриевич");
			teacher2 = teacher1.DeepCopy();

			Console.WriteLine("Глубокая копия 1-го объекта во 2-ой:");
			teacher1.DisplayInfo();
			teacher2.DisplayInfo();
			Console.WriteLine("");
			Console.WriteLine("Изменение 1-го объекта, а 2-ой не трогается:");
			teacher1.Set("Иванова", "Марина", "Витальевна");
			teacher1.DisplayInfo();
			teacher2.DisplayInfo();
			Console.WriteLine("\n\n");

		}
	}
}
