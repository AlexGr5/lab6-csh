using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    // Структура оценка
    public struct Mark
    {
        private int value /*= 0*/;          // Оценка

        // Конструктор
        //public Mark()
        //{
        //    value = 0;
        //}

        // Конструктор с параметром
        public Mark(int Value)
        {
            value = Value;
        }

        // Задание полей класса Оценка
        public void Set(int v)
        {
            value = v;
        }

        // Получение оценки
        public int Get()
        {
            return value;
        }

        // Ввод данных в класс Оценка
        public void InpMark()
        {
            string mark;
            Console.Write("Введите оценку: ");
            mark = Console.ReadLine();
            value = Convert.ToInt32(mark);
            Console.Write("\n");
        }

        // Вывод данных на дисплей
        public void DisplayValue()
        {
            Console.Write("Оценка: " + value + "\n");
        }

        // Проверка возврата значения по ref
        public void TestRef4(ref int Value)
        {
            Value = 4;
        }

        // Проверка возврата значения по out
        public void TestOut5(out int Value)
        {
            Value = 5;
        }

        public static Mark operator +(Mark operand1, Mark operand2)
            => new Mark(operand1.value + operand2.value);

        public static Mark operator ++(Mark operand1)
            => new Mark(operand1.value + 1);
    }
}
