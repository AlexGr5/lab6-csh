using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    // Класс Учитель
    public class Teacher
    {
        // Фамилия
        public string fam
        {
            get { return fam; }
            set { fam = value; }
        }

        // Имя
        public string name
        {
            get { return name; }
            set { name = value; }
        }

        // Отчество
        public string otch
        {
            get { return otch; }
            set { otch = value; }
        }

        // Конструктор
        public Teacher()
        {
            fam = "";
            name = "";
            otch = "";
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

    }
}
