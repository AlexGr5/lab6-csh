using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    // Класс ученик
    class Student : Persone
    {
        //private string fam = "";                    // Фамилия
        //private string name = "";                   // Имя
        //private string otch = "";                   // Отчество
        private Mark<int>[] marks = new Mark<int>[20];       // Массив оценок
        private Lesson[] lessons = new Lesson[20];  // Массив уроков
        private int countLess = 0;                  // Текущее кол-во уроков

        // Конструктор
        public Student() : base("", "", "")
        {
            fam = "";
            name = "";
            otch = "";
            Lesson L = new Lesson();
            Mark<int> M = new Mark<int>();
            L.Null();
            M.Set(0);
            countLess = 0;
            for (int i = 0; i< 20; i++)
            {
                lessons[i] = L;
            }

            for (int i = 0; i< 20; i++)
            {
                marks[i] = M;
            }
        }

        // Конструктор с одним параметром
        public Student(string Fam) : base(Fam, "", "")
        {
            fam = Fam;
            name = "";
            otch = "";
            Lesson L = new Lesson();
            Mark<int> M = new Mark<int>();
            L.Null();
            M.Set(0);
            countLess = 0;
            for (int i = 0; i< 20; i++)
            {
                lessons[i] = L;
            }

            for (int i = 0; i< 20; i++)
            {
                marks[i] = M;
            }

        }

        // Конструктор с параметрами
        public Student(string Fam, string Name, string Otch, Mark<int>[] mas_m, int LenMark, Lesson[] mas_l, int LenLess)
            : base(Fam, Name, Otch)
        {
            this.fam = Fam;
            this.name = Name;
            this.otch = Otch;

            this.countLess = 0;

            int i = 0;
            for (i = 0; i < LenLess && i < 20; i++)
            {
                lessons[i] = mas_l[i];
                this.countLess++;
            }

            for (i = 0; i < LenMark && i < 20; i++)
            {
                marks[i] = mas_m[i];
            }
        }

        // Очищение всех полей класса Ученик (Student)
        public void Null()
        {

            fam = "";
            name = "";
            otch = "";
            Lesson L = new Lesson();
            Mark<int> M = new Mark<int>();
            L.Null();
            M.Set(0);
            this.countLess = 0;
            for (int i = 0; i < 20; i++)
            {
                lessons[i] = L;
            }

            for (int i = 0; i < 20; i++)
            {
                marks[i] = M;
            }
        }


        // Функции получения значений полей
        public string GetFam()
        {
            return this.fam;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetOtch()
        {
            return this.otch;
        }

        public Mark<int> GetMarkByNumber(int i)
        {
            Mark<int> m = new Mark<int>();
            if (i < 20 && i > -1)
                m = marks[i];

            return m;
        }

        public Lesson GetLessByNumber(int i)
        {
            Lesson l = new Lesson();
            if (i < 20 && i > -1)
                l = lessons[i];

            return l;
        }

        // Установка фамилии
        public void SetFam(string Fam)
        {
            fam = Fam;
        }

        // Установка Имени
        public void SetName(string Name)
        {
            name = Name;
        }

        // Установка Отчества
        public void SetOtch(string Otch)
        {
            otch = Otch;
        }

        // Установка Оценок
        public void SetMarks(Mark<int>[] mas_m, int LenMark)
        {
            for (int i = 0; i < LenMark && i < 20; i++)
            {
                marks[i] = mas_m[i];
            }
        }

        // Установка Уроков
        public void SetLessons(Lesson[] mas_l, int LenLess)
        {
            int i = 0;
            for (i = 0; i < LenLess && i < 20; i++)
            {
                lessons[i] = mas_l[i];
                this.countLess++;
            }
        }

        // Задание полей класса Ученик
        public void Set(string Fam, string Name, string Otch, Mark<int>[] mas_m, int LenMark, Lesson[] mas_l, int LenLess)
        {
            this.fam = Fam;
            this.name = Name;
            this.otch = Otch;

            this.countLess = 0;

            int i = 0;
            for (i = 0; i < LenLess && i < 20; i++)
            {
                lessons[i] = mas_l[i];
                this.countLess++;
            }

            for (i = 0; i < LenMark && i < 20; i++)
            {
                marks[i] = mas_m[i];
            }
        }

        // Ввод ФИО ученика в класс
        public override void InpFIO()
        {
            Console.Write("Введите Фамилию ученика: ");
            fam = Console.ReadLine();
            Console.Write("Введите Имя ученика: ");
            name = Console.ReadLine();
            Console.Write("Введите Отчество ученика: ");
            otch = Console.ReadLine();
        }

        // Добавление к ученику урока
        // 0 - не удачно, 1 - удачно
        public bool AddLess(Lesson ls)
        {
            bool fl = false;

            for (int i = 0; (i < 20) && (fl == false); i++)
            {
                if (lessons[i].GetNameLess() == "")
                {
                    lessons[i] = ls;
                    this.countLess++;
                    fl = true;
                }
            }

            return fl;
        }

        // Добавление к ученику урока и оценки
        // 0 - не удачно, 1 - удачно
        public bool AddLessAndMark(Lesson ls, Mark<int> m)
        {
            bool fl = false;

            for (int i = 0; (i < 20) && (fl == false); i++)
            {
                if (lessons[i].GetNameLess() == "")
                {
                    lessons[i] = ls;
                    marks[i] = m;
                    this.countLess++;
                    fl = true;
                }
            }

            return fl;
        }

        // Добавление к ученику оценки к конкретному предмету
        // 0 - не удачно, 1 - удачно
        public bool AddMark(Lesson ls, Mark<int> m)
        {
            bool fl = false;

            for (int i = 0; (i < 20) && (fl == false); i++)
            {
                if (lessons[i].GetNameLess() == ls.GetNameLess())
                {
                    if (lessons[i].GetTeacher().GetFam() == ls.GetTeacher().GetFam())
                    {
                        if (lessons[i].GetTeacher().GetName() == ls.GetTeacher().GetName())
                        {
                            if (lessons[i].GetTeacher().GetOtch() == ls.GetTeacher().GetOtch())
                            {
                                marks[i] = m;
                                fl = true;
                            }
                        }
                    }
                }
            }

            return fl;
        }

        // Вывод ученика
        public override void DisplayInfo()
        {
            Console.Write("ФИО ученика: " + fam + " " + name + " " + otch + "\n");

            Console.Write("Уроки:" + "\n");
            int i = 0;
            for(i = 0; i < countLess; i++)
            {
                Console.Write(" * " + lessons[i].GetNameLess() + " * " + marks[i].Get() + " * " + "\n");
            }
        }




        // Вывод ученика со всеми предметами, даже пустыми
        public void DispFullInfo()
        {
            Console.Write("ФИО ученика: " + fam + " " + name + " " + otch + "\n");

            Console.Write("Уроки:" + "\n");
            for (int i = 0; i < 20; i++)
            {
                lessons[i].DisplayInfo();
            }

            Console.Write("Оценки:" + "\n");
            for (int i = 0; i < 20; i++)
            {
                marks[i].DisplayValue();
            }
        }

        // Виртуальная функция вывода сообщения на екран, кем является человек (рабочим, учителем, учеником)
        public override string WhoIs()
        {
            return "ученик";
        }

        // Поверхностное копирование
        public Student ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }

        // Глубокое копирование
        public Persone DeepCopy()
        {
            Student other = (Student)this.MemberwiseClone();
            other.fam = String.Copy(fam);
            other.name = String.Copy(name);
            other.otch = String.Copy(otch);
            return other;
        }

    }
}
