using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    interface IHuman
    {
        // Ввод ФИО человека
        void InpFIO();

        // Вывод человека
        void DisplayInfo();

        // Виртуальная/не виртуальная функция вывода сообщения на екран, кем является человек (рабочим, учителем, учеником)
        string WhoIs();

        // Поверхностное копирование
        public Persone ShallowCopy();

        // Глубокое копирование
        public Persone DeepCopy();
    }

    // Класс персона
    public /*abstract*/ class Persone : IHuman
    {
        // Фамилия
        protected string fam;

        // Имя
        protected string name;

        // Отчество
        protected string otch;


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
        public Persone()
        {
            fam = "";
            name = "";
            otch = "";
        }

        // Конструктор с одним параметром
        public Persone(string Fam)
        {
            fam = Fam;
            name = "";
            otch = "";
        }

        // Конструктор с параметрами
        public Persone(string Fam, string Name, string Otch)
        {
            fam = Fam;
            name = Name;
            otch = Otch;
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

        // Ввод ФИО человека
        public /*virtual*/ void InpFIO()
        {
            Console.Write("Введите Фамилию: ");
            fam = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            otch = Console.ReadLine();
        }

        // Вывод человека
        public /*virtual*/ void DisplayInfo()
        {
            Console.Write("ФИО: " + fam + " " + name + " " + otch + "\n");

        }

        // Обработка строк
        public void AdditionSapces()
        {
            fam = fam + "  ";
            name = name + "  ";
            otch = otch + "  ";
        }

        // Виртуальная/не виртуальная функция вывода сообщения на екран, кем является человек (рабочим, учителем, учеником)
        public virtual string WhoIs()
        {
            return "рабочий";
        }

        // Сказать привет
        public void SayHello()
        {
            Console.WriteLine( WhoIs() + " говорит привет!");
        }

        // Поверхностное копирование
        public Persone ShallowCopy()
        {
            return (Persone)this.MemberwiseClone();
        }

        // Глубокое копирование
        public Persone DeepCopy()
        {
            Persone other = (Persone)this.MemberwiseClone();
            other.fam = String.Copy(fam);
            other.name = String.Copy(name);
            other.otch = String.Copy(otch);
            return other;
        }
    }
}
