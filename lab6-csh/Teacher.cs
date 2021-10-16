using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    // Класс Учитель
    public class Teacher
    {
        private string fam = "";        // Фамилия
        private string name = "";       // Имя
        private string otch = "";       // Отчество


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

        // Инициализация структуры Учитель
        public void Set(string Fam_s, string Name_s, string Otch_s)
        {
            this.fam = Fam_s;
            this.name = Name_s;
            this.otch = Otch_s;
        }

        // Ввод учителя
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
