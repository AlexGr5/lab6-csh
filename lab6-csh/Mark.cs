using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    public class Mark
    {
        private int value = 0;          // Оценка

        // Конструктор
        public Mark()
        {
            value = 0;
        }

        // Инициализация структуры Оценка
        public void Set(int v)
        {
            value = v;
        }

        // Получение оценки
        public int Get()
        {
            return value;
        }

        // Ввод данных в структуру Оценка
        public void InpMark()
        {
            string mark;
            Console.Write("Введите оценку: ");
            mark = Console.ReadLine();
            value = Convert.ToInt32(mark);
            Console.Write("\n");
        }

        // Вывод данных из структуры
        public void DisplayValue()
        {
            Console.Write("Оценка: " + value + "\n");

        }

    }
}
