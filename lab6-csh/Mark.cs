using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_csh
{
    // Класс оценка
    public class Mark<T>
    {
        private T value;          // Оценка

        // Конструктор
        public Mark()
        {
            //value = 0;
        }

        // Конструктор с параметром
        public Mark(T Value)
        {
            //this.value = 0;
            //if (IsRightMark(Value))
                this.value = Value;
        }

        // Задание полей класса Оценка
        public void Set(T v)
        {
            //this.value = 0;
            //if (IsRightMark(v))
                this.value = v;
        }

        // Получение оценки
        public T Get()
        {
            return value;
        }

        // Вывод данных на дисплей
        public void DisplayValue()
        {
            Console.Write("Оценка: " + value + "\n");
        }


        /*
        // Ввод данных в класс Оценка
        public void InpMark()
        {
            string mark;
            Console.Write("Введите оценку: ");
            mark = Console.ReadLine();
            value = Convert.ToInt32(mark);
            Console.Write("\n");
        }
        */

        /*
        // Ввод данных в Класс Оценка
        public void InpMark()
        {
            string mark;
            Console.Write("Введите оценку: ");
            mark = Console.ReadLine();

            try                                                 // ищем исключения внутри этого блока и отправляем их в соответствующий обработчик catch          
            {
                for (int i = 0; i < mark.Length; i++)
                {
                    if ((mark[i] < '0') || (mark[i] > '9'))
                        throw new Exception("It string is not number!");       // выбрасывается исключение
                }
                Set(Convert.ToInt32(mark));
            }
            catch (Exception ex)                       // обработчик исключений типа const char*
            {
                Console.Write("Error: " + ex.Message + '\n');
                //std::cerr << "Error: " << "It string is not number!" << '\n';
            }
        }
        */

        

        /*
        // Проверка возврата значения по ref
        public void TestRef4(ref T Value)
        {
            Value = 4;
        }

        // Проверка возврата значения по out
        public void TestOut5(out int Value)
        {
            Value = 5;
        }
        */

        /*
        public static Mark operator +(Mark operand1, Mark operand2)
            => new Mark(operand1.value + operand2.value);

        public static Mark operator ++(Mark operand1)
            => new Mark(operand1.value + 1);

        // Поверхностная копия
        public Mark ShallowCopy()
        {
            return (Mark)this;
        }

        // Глубокая копия
        public Mark DeepCopy()
        {
            Mark other = (Mark)this.MemberwiseClone();
            other.Set(value);
            return other;
        }

        // Проверка числа на подходяее для оценки
        public bool IsRightMark(int mark)
        {
            bool res = true;
            try                                                    // ищем исключения внутри этого блока и отправляем их в соответствующий обработчик catch
            {
                if (mark < 0 || mark > 5)                          // Если пользователь ввел неверное число, то выбрасывается исключение
                    throw new Exception("Incorrect value.");       // выбрасывается исключение типа const char*
                return res;
            }
            catch (Exception ex)           // обработчик исключений типа const char*
            {
                Console.WriteLine("Error: " + ex.Message + '\n');
                res = false;
                return res;
            }

            //return res;
        }
        */


        }
}
