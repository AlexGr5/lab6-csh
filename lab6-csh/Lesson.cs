using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    // Класс Урок
    public class Lesson
    {
        private string nameLesson = "";             // Название предмета
        private Teacher teacher = new Teacher();    // Учитель

        // Конструктор
        public Lesson()
        {
            this.nameLesson = "";
            this.teacher.Set("", "", "");
        }

        // Задание полей класса Урок
        public void Set(string Name_Less, Teacher t)
        {
            nameLesson = Name_Less;
            teacher = t;
        }

        // Обнуление полей
        public void Null()
        {
            this.nameLesson = "";
            this.teacher.Set("", "", "");
        }

        // Фун-ии получения данных из полей
        public string GetNameLess()
        {
            return this.nameLesson;
        }

        public Teacher GetTeacher()
        {
            return this.teacher;
        }

        // Ввод названия урока
        public void InpInConsol(Teacher t)
        {
            Console.Write("Введите название предмета: ");
            nameLesson = Console.ReadLine();
            Console.Write("\n");
            teacher = t;

        }

        // Вывод урока
        public void DisplayInfo()
        {
            Console.Write("Название предмета: " + nameLesson + "\n");
            teacher.DisplayInfo();
        }

        // Вывод урока с подписью, что этот урок очень важен
        public void DisplayImportantInfo()
        {
            Console.Write("Этот урок очень важен!\n");
            // Вызыв метода через указатель this
            this.DisplayInfo();
        }

    }
}
