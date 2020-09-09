using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Типы данных

            bool b = true;
            int i = -10;
            uint ui = 10;
            byte by = 255;
            sbyte sb = -120;
            long li = -20000;
            ulong ul = 20000;
            short sh = -100;
            ushort ush = 100;
            decimal dec = 10.6m;
            double db = 2e10;
            float fl = 10.7f;
            char ch = '!';

            Console.WriteLine("Заранее инициализированные значения");
            Console.WriteLine($"Логический тип данных bool: {b}");
            Console.WriteLine($"Логический тип данных int: {i}");
            Console.WriteLine($"Логический тип данных uint: {ui}");
            Console.WriteLine($"Логический тип данных long: {li}");
            Console.WriteLine($"Логический тип данных ulong: {ul}");
            Console.WriteLine($"Логический тип данных short: {sh}");
            Console.WriteLine($"Логический тип данных ushort: {ush}");
            Console.WriteLine($"Логический тип данных byte: {by}");
            Console.WriteLine($"Логический тип данных sbyte: {sb}");
            Console.WriteLine($"Логический тип данных decimal: {dec}");
            Console.WriteLine($"Логический тип данных double: {db}");
            Console.WriteLine($"Логический тип данных float: {fl}");
            Console.WriteLine($"Логический тип данных char: {ch}");
            Console.WriteLine();

            Console.WriteLine("Введите значения типа bool (true/false):");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Введите значения типа int:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения типа uint:");
            ui = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите значения типа long:");
            li = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите значения типа ulong:");
            ul = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Введите значения типа short:");
            sh = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите значения типа ushort:");
            ush = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введите значения типа byte:");
            by = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите значения типа sbyte:");
            sb = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите значения типа decimal:");
            dec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите значения типа double:");
            db = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения типа float:");
            fl = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите значения типа char:");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Значения введенные с консоли");
            Console.WriteLine($"Логический тип данных bool: {b}");
            Console.WriteLine($"Логический тип данных int: {i}");
            Console.WriteLine($"Логический тип данных uint: {ui}");
            Console.WriteLine($"Логический тип данных long: {li}");
            Console.WriteLine($"Логический тип данных ulong: {ul}");
            Console.WriteLine($"Логический тип данных short: {sh}");
            Console.WriteLine($"Логический тип данных ushort: {ush}");
            Console.WriteLine($"Логический тип данных byte: {by}");
            Console.WriteLine($"Логический тип данных sbyte: {sb}");
            Console.WriteLine($"Логический тип данных decimal: {dec}");
            Console.WriteLine($"Логический тип данных double: {db}");
            Console.WriteLine($"Логический тип данных float: {fl}");
            Console.WriteLine($"Логический тип данных char: {ch}");
            Console.WriteLine();

            Console.WriteLine("Неяное приведение типов");
            li = i;
            i = sh;
            ui = ush;
            fl = by;
            db = sb;
            Console.WriteLine($"Неяное приведение int к long: {li}");
            Console.WriteLine($"Неяное приведение short к int: {i}");
            Console.WriteLine($"Неяное приведение ushort к uint: {ui}");
            Console.WriteLine($"Неяное приведение byte к float: {fl}");
            Console.WriteLine($"Неяное приведение sbyte к double: {db}");
            Console.WriteLine();

            Console.WriteLine("Явное преобразование");
            ul = (ulong)ui;
            by = (byte)ch;
            db = (double)fl;
            dec = (decimal)ush;
            li = (long)sb;
            Console.WriteLine($"Явное приведение uint к ulong: {ul}");
            Console.WriteLine($"Явное приведение char к byte: {by}");
            Console.WriteLine($"Явное приведение float к double: {db}");
            Console.WriteLine($"Явное приведение ushort к decimal: {dec}");
            Console.WriteLine($"Явное приведение sbyte к long: {li}");
            Console.WriteLine();

            Console.WriteLine("Упаковка и распаковка значимых типов");
            object obj = ui;
            Console.WriteLine($"Упаковка: {obj}");
            ui = (uint)obj;
            Console.WriteLine($"Распаковка: {ui}");
            Console.WriteLine();

            Console.WriteLine("Неявно типизированная переменная");
            var variable = 10.2m;
            Console.WriteLine($"Неявно типизированная переменная с помощью ключевого слова var {variable}");
            Console.WriteLine();

            Console.WriteLine("Nullable переменная");
            int? nullable = null;
            Console.WriteLine($"Значение nullable переменной {nullable}");
            Console.WriteLine();

            //Ошибка при присвоении переменной типа var значения другого типа
            var err = 23;
            //err = 2.54f; - ошибка, не удается неявно преобразовать "float" в "int"

            //Строки

            Console.WriteLine("Сравнение строк");
            string str1, str2;
            Console.WriteLine("Введите первую строку: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            str2 = Console.ReadLine();
            int iCompare = String.Compare(str1, str2);
            if (iCompare > 0)
            {
                Console.WriteLine("Вторая строка следует раньше в алфавитном порядке");
            }
            else if (iCompare < -1)
            {
                Console.WriteLine("Вторая строка следует позже в алфавитном порядке");
            }
            else
                Console.WriteLine("Строки равны");

            string str3 = null;
            string str4, str5;
            Console.WriteLine("Введите строку: ");
            str3 = Console.ReadLine();
            Console.WriteLine("Введите строку: ");
            str4 = Console.ReadLine();
            Console.WriteLine("Введите строку: ");
            str5 = Console.ReadLine();
            Console.WriteLine($"Интерполяция: {str3}");
            str4 = String.Copy(str3);
            Console.WriteLine($"Копирование: {str4}");
            int n = 0;
            bool flag = true;
            Console.WriteLine("Введите индекс символа, начиная с которого нужно вставить подстроку: ");
            while (flag)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < str4.Length)
                {
                    flag = false;
                }
                else Console.WriteLine("Неверный ввод! Повторите снова!");
            }
            
            str4 = str4.Substring(n);
            Console.WriteLine($"Полученная подстрока: {str4}");
            Console.WriteLine("Введите текст:");
            str5 = Console.ReadLine();
            string[] words = str5.Split(' ');
            Console.WriteLine("Слова, полученные после разбиения строки");
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            flag = true;

            Console.WriteLine("Введите индекс позиции, с которой будет вставляться подстрока: ");
            while (flag)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < str5.Length)
                {
                    flag = false;
                }
            }
            str5 = str5.Insert(n, str3);
            Console.WriteLine($"Третья строка после вставки в нее подстроки: {str5}");
            str5 = str5.Remove(n, str3.Length);
            Console.WriteLine($"Третья строка после удаления из нее подстроки: {str5}");
            str3 = String.Concat(str3, " and goodbye");
            Console.WriteLine($"Конкатенация с помощью метода String.Concat(): {str3}");

            //Массивы

            Console.WriteLine("Матрица:");
            int[,] Matrix = new int[4, 4];
            Random Elem = new Random();
            for (int I = 0; I < 4; I++) 
            {
                for (int j = 0; j < 4; j++)
                {
                    Matrix[I, j] = Elem.Next(1, 10);
                    Console.Write("{0}  ", Matrix[I, j]);
                }
                Console.WriteLine();
            }

            string[] arrOfStr = new string[] {"Hello", "Programming", "World", "String", "Parachute" };
              
            foreach(string el in arrOfStr)
            {
                Console.Write(el + ", ");
            }

            Console.WriteLine();
            Console.WriteLine($"Длина массива: {arrOfStr.Length}");
            flag = true;
            Console.WriteLine("Введите индекс строки в массиве, которую вы хотите заменить:");

            while (flag)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < arrOfStr.Length)
                {
                    flag = false;
                }
            }

            Console.WriteLine("Введите новую строку!");
            str3 = Console.ReadLine();

            for (int I = 0; I < arrOfStr.Length; I++)
            {
                if(I == n)
                {
                    arrOfStr[I] = str3;
                    break;
                }
            }

            Console.WriteLine("Измененный массив:");

            foreach (string el in arrOfStr)
            {
                Console.Write(el + ", ");
            }

            int[][] step = new int[3][];
            step[0] = new int[2];
            step[1] = new int[3];
            step[2] = new int[4];
            Console.WriteLine();
            Console.WriteLine("Заполнение ступенчатого массива:");

            for (int I = 0; I < step[0].Length; I++)
            {
                Console.WriteLine("Введите число: ");
                step[0][I] = Convert.ToInt32(Console.ReadLine());
            }
            for (int I = 0; I < step[1].Length; I++)
            {
                Console.WriteLine("Введите число: ");
                step[1][I] = Convert.ToInt32(Console.ReadLine());
            }
            for (int I = 0; I < step[2].Length; I++)
            {
                Console.WriteLine("Введите число: ");
                step[2][I] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ступенчатый массив: ");
            for (int I = 0; I < step[0].Length; I++)
                Console.Write($"{step[0][I]} ");
            Console.WriteLine();
            for (int I = 0; I < step[1].Length; I++)
                Console.Write($"{step[1][I]} ");
            Console.WriteLine();
            for (int I = 0; I < step[2].Length; I++)
                Console.Write($"{step[2][I]} ");
            Console.WriteLine();

            var varString = "Greetings";
            Console.WriteLine($"Неявно типизированная переменная для хранения данных типа String: {varString}");
            var Arr = new[] { 2, 3, 4 };
            Console.WriteLine("Неявно типизированная переменная для хранения массива с данными типа int: {0}, {1}, {2}", Arr[0], Arr[1], Arr[2]);
            
            //Кортежи

            (int, string, char, string, ulong) T = (5, "Tuple", '!', "Laboratory", 454252536);
            Console.WriteLine($"Элементы кортежа: {T.Item1}, {T.Item2}, {T.Item3}, {T.Item4}, {T.Item5}");
            (int a1, string a2, char a3, string a4, ulong a5) Tu = (5, "Tuple", '!', "Laboratory", 454252536);
            Console.WriteLine($"Элементы кортежа: { Tu.a1}, { Tu.a2}, { Tu.a3}, { Tu.a4}, { Tu.a5}");
            if (T == Tu)
            {
                Console.WriteLine("Кортежи равны!");
            }
            else Console.WriteLine("Кортежи не равны!");

            var (_, city, _, popularity) = (10, "city", 3, 1000);
            Console.WriteLine($"Город: {city}, население: {popularity}");

            int[] ToFun = new int[10];
            for(int I = 0; I < ToFun.Length; I++)
            {
                ToFun[I] = Elem.Next(1, 10);
                Console.Write($"{ToFun[I]} ");
            }
            Console.WriteLine();
            (int, int, int, char) Tup = MaxMinSumFirst(ref ToFun, "hello");
            (int, int, int, char) MaxMinSumFirst(ref int[] Arrr,  string Str)
            {
                int Max, Min, Sum = 0;
                char ch1 = Str[0];
                Min = Max = Arrr[0];
                foreach(int m in Arrr)
                {
                    if (m > Max)
                        Max = m;
                    if (m < Min)
                        Min = m;
                    Sum += m;
                }
                (int, int, int, char) Tuple = (Max, Min, Sum, ch1);
                return Tuple;
            }
            Console.WriteLine($"Максимальный элемент массива: {Tup.Item1}.\n Минимальный элемент: {Tup.Item2}.\n Сумма элементов: {Tup.Item3}.\n Первая буква строки: {Tup.Item4}");
            
            void a()
            {
                checked
                {
                    int a1 = checked(2147483647);
                    a1++;
                }
            }
            void b1()
            {
                unchecked
                {
                    int a2 = 2147483647;
                    a2++;
                }
            }
            a();
            b1();
        }
    }
}
