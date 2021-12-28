using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{

    // Класс Учитель
    public class Teacher : Persone
    {
        // Фамилия
        //private string fam;

        // Имя
        //private string name;

        // Отчество
        //private string otch;

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
        public Teacher() : base("", "", "")
        {
            //fam = "";
            //name = "";
            //otch = "";
        }

        // Конструктор с одним параметром
        public Teacher(string Fam) : base(Fam, "", "")
        {
            //fam = Fam;
            //name = "";
            //otch = "";
        }

        // Конструктор с параметрами
        public Teacher(string Fam, string Name, string Otch) : base(Fam, Name, Otch)
        {
            //fam = Fam;
            //name = Name;
            //otch = Otch;
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

        // Установить фамилию
        public void SetFam(string Fam)
        {
            fam = Fam;
        }

        // Установить имя
        public void SetName(string Name)
        {
            name = Name;
        }

        // Установить отчество
        public void SetOtch(string Otch)
        {
            otch = Otch;
        }

        // Задание полей класса Учитель
        public void Set(string Fam_s, string Name_s, string Otch_s)
        {
            this.fam = Fam_s;
            this.name = Name_s;
            this.otch = Otch_s;
        }

        // Ввод ФИО учителя
        public /*override*/ void InpFIO()
        {
            Console.Write("Введите Фамилию учителя: ");
            fam = Console.ReadLine();
            Console.Write("Введите имя учителя: ");
            name = Console.ReadLine();
            Console.Write("Введите отчество учителя: ");
            otch = Console.ReadLine();
        }

        // Ввод учителя
        public /*override*/ void DisplayInfo()
        {
            Console.Write("ФИО учителя: " + fam + " " + name + " " + otch + "\n");

        }

        // Метод ToString
        public String ToString()
        {
            return (fam + " " + name + " " + otch);
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

        // Виртуальная/не виртуальная функция вывода сообщения на екран, кем является человек (рабочим, учителем, учеником)
        public override string WhoIs()
        {
            return "учитель";
        }

        // Поверхностное копирование
        public Teacher ShallowCopy()
        {
            return (Teacher)this.MemberwiseClone();
        }

        // Глубокое копирование
        public Teacher DeepCopy()
        {
            Teacher other = (Teacher)this.MemberwiseClone();
            other.fam = String.Copy(fam);
            other.name = String.Copy(name);
            other.otch = String.Copy(otch);
            return other;
        }
    }
}
