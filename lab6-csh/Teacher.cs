using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    // Класс Учитель
    public class Teacher
    {
        // Фамилия
        private string fam;

        // Имя
        private string name;

        // Отчество
        private string otch;

        private static Teacher lastTeacher;
        private Teacher prev;
        private Teacher next;

        public string Fam
        {
            get => fam;
            set => fam = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Otch
        {
            get => otch;
            set => otch = value;
        }

        // Конструктор
        public Teacher()
        {
            fam = "";
            name = "";
            otch = "";
        }

        // Конструктор с параметрами
        public Teacher(string Fam_s, string Name_s, string Otch_s)
        {
            this.fam = Fam_s;
            this.name = Name_s;
            this.otch = Otch_s;
        }

        // Фун-ии получения данных из полей
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

        // Задание полей класса Учитель
        public void Set(string Fam_s, string Name_s, string Otch_s)
        {
            this.fam = Fam_s;
            this.name = Name_s;
            this.otch = Otch_s;
        }

        // Ввод ФИО учителя
        public void InpFIO()
        {
            Console.Write("Введите Фамилию учителя: ");
            fam = Console.ReadLine();
            Console.Write("Введите имя учителя: ");
            name = Console.ReadLine();
            Console.Write("Введите отчество учителя: ");
            otch = Console.ReadLine();
        }

        // Ввод учителя
        public void DisplayInfo()
        {
            Console.Write("ФИО учителя: " + fam + " " + name + " " + otch + "\n");

        }

        // Обработка строк
        public void AdditionSapces()
        {
            fam = fam + "  ";
            name = name + "  ";
            otch = otch + "  ";
        }


        // Новый список
        public static void NewList()
        {
            lastTeacher = null;
        }

        // Добавление элемента в конец списка
        public void Add()
        {
            if (lastTeacher == null)
                this.prev = null;
            else
            {
                lastTeacher.next = this;
                prev = lastTeacher;
            }
            lastTeacher = this;
            this.next = null;
        }

        // Вывод на дисплей содержимого списка
        public static void reprint()
        {
            Teacher uk;   // Вспомогательная ссылка
            uk = lastTeacher;
            if (uk == null)
            {
                Console.WriteLine("Список пуст!");
                return;
            }
            else
                Console.WriteLine("\nСодержимое списка:\n");

            // Цикл печати в обратном порядке значений элементов списка:
            while (uk != null)
            {
                Console.WriteLine(uk.GetFam() + " " + uk.GetName() + " " + uk.GetOtch() +  " " + "\t");
                uk = uk.prev;
            }
        }
    }
}
