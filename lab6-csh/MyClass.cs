using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    // Класс Мой Класс
    class MyClass
    {
        private string className = "";                  // Название класса
        private string yearOfStudy = "";                // Год обучения
        private int contStuds = 0;                      // Текущее кол-во учеников
        private Student[] students = new Student[32];   // Массив учеников

        // Конструктор
        public MyClass()
        {
            className = "";
            yearOfStudy = "";
            contStuds = 0;
            Student S = new Student();
            S.Null();
            for (int i = 0; i< 32; i++)
            {
                students[i] = S;
            }
        }

        // Конструктор с одним параметром
        public MyClass(string ClassName)
        {
            className = ClassName;
            yearOfStudy = "";
            contStuds = 0;
            Student S = new Student();
            S.Null();
            for (int i = 0; i< 32; i++)
            {
                students[i] = S;
            }
        }

        // Конструктор с параметрами
        public MyClass(string Name, string Year, Student[] mas, int LenStud)
        {
            this.className = Name;
            this.yearOfStudy = Year;
            this.contStuds = 0;
            for (int i = 0; i < 32 && i < LenStud; i++)
            {
                students[i] = mas[i];
                contStuds++;
            }
        }

        // Очищение полей класса Мой Класс
        public void Null()
        {
            className = "";
            yearOfStudy = "";
            contStuds = 0;
            Student S = new Student();
            S.Null();
            for (int i = 0; i < 32; i++)
            {
                students[i] = S;
            }
        }

        // Установка Названия
        public void SetName(string Name)
        {
            className = Name;
        }

        // Установка Года
        public void SetYear(string Year)
        {
            yearOfStudy = Year;
        }

        // Установка учеников
        public void SetStuds(Student[] mas, int LenStud)
        {
            for (int i = 0; i < 32 && i < LenStud; i++)
            {
                students[i] = mas[i];
                contStuds++;
            }
        }


        // Задание полей класса Мой Класс
        public void Set(string Name, string Year, Student[] mas, int LenStud)
        {
            this.className = Name;
            this.yearOfStudy = Year;
            this.contStuds = 0;
            Student S = new Student();
            S.Null();
            for (int i = 0; i < 32 && i < LenStud; i++)
            {
                students[i] = mas[i];
                contStuds++;
            }
        }


        // Функции получения значений полей
        public string GetName()
        {
            return className;
        }

        public string GetYear()
        {
            return yearOfStudy;
        }



        // Ввод данных в Мой Класс
        public void InpNameYear()
        {
            Console.Write("Введите название класса: ");
            className = Console.ReadLine();
            Console.Write("\n");
            Console.Write("Введите год обучения: ");
            yearOfStudy = Console.ReadLine();
            Console.Write("\n");
        }

        // Добавление к классу ученика
        public bool AddStud(Student st)
        {
            bool fl = false;
            if (contStuds < 20)
            {
                students[contStuds] = st;
                contStuds++;
                fl = true;
            }

            return fl;
        }

        // Вывод данных из класса Мой Класс
        public void DisplayShortInfo()
        {

            Console.Write("Название класса: " + className + "\n");
            Console.Write("Год обучения: " + yearOfStudy + "\n");
            Console.Write("\n");
            Console.Write("Ученики:" + "\n");

            int i = 0;
            for (i = 0; i < contStuds; i++)
            {
                students[i].DisplayInfo();
            }

        }

        // Выод всех данных из класса Мой Класс
        public void DispFullInfo()
        {
            Console.Write("Название класса: " + className + "\n"); ;
            Console.Write("Год обучения: " + yearOfStudy + "\n");
            Console.Write("\n");
            Console.Write("Ученики:" + "\n");

            int i = 0;
            for(i = 0; i < 30; i++)
            {
                students[i].DispFullInfo();
            }
        }

        // Функция по нахождению лучших учеников в 'классе'
        public bool BestStud()
        {
            double[] mas_m = new double[32];
            bool exit = false;

            int i = 0;

            for (i = 0; i < 32; i++)
            {
                mas_m[i] = 0;
            }

            i = 0;
            int k = 0;
            double sum = 0;
            while (students[i].GetFam() != "")
            {
                int j = 0;
                k = 0;
                sum = 0;
                while (students[i].GetLessByNumber(j).GetNameLess() != "")
                {
                    sum += students[i].GetMarkByNumber(j).Get();
                    k++;
                    j++;
                }
                mas_m[i] = sum / k;
                i++;
            }

            if (i > 0)
            {
                double maxM = 0;
                maxM = mas_m[0];
                for (int j = 0; j < i; j++)
                {
                    if (maxM < mas_m[j])
                        maxM = mas_m[j];
                }

                for (int j = 0; j < i; j++)
                {
                    if (mas_m[j] == maxM)
                        students[j].DisplayInfo();
                }

                exit = true;
            }

            return exit;
        }

        // Функция по нахождению худших учеников в 'классе'
        public bool BedStud()
        {
            double[] mas_m = new double[32];
            bool exit = false;

            int i = 0;

            for (i = 0; i < 32; i++)
            {
                mas_m[i] = 0;
            }

            i = 0;
            int k = 0;
            double sum = 0;
            while (students[i].GetFam() != "")
            {
                int j = 0;
                k = 0;
                sum = 0;
                while (students[i].GetLessByNumber(j).GetNameLess() != "")
                {
                    sum += students[i].GetMarkByNumber(j).Get();
                    k++;
                    j++;
                }
                mas_m[i] = sum / k;
                i++;
            }

            if (i > 0)
            {
                double minM = 0;
                minM = mas_m[0];
                for (int j = 0; j < i; j++)
                {
                    if (minM > mas_m[j])
                        minM = mas_m[j];
                }

                for (int j = 0; j < i; j++)
                {
                    if (mas_m[j] == minM)
                        students[j].DisplayInfo();
                }
                exit = true;
            }

            return exit;
        }
    }
}
