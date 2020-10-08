using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{

    class Program
    {
         static void Main(string[] args)
        {
            ////Определение переменных всех возможных примитивных типов

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            ///*целое число - 4 байта*/
            //int i = -4;
            ///*логический литерал*/
            //bool b = false;
            ///*целое число - 2 байта*/
            //short sh = 2;
            ///*целое натуральное число число - 1 байт*/
            //byte by = 1;
            ///*целое число - 1 байт*/
            //sbyte sby = -1;
            ///*целое натуральное число - 2 байта*/
            //ushort ush = 2;
            ///*целое натуральное число число - 4 байта*/
            //uint ui = 4;
            ///*целое число - 8 байт*/
            //long l = 8;
            ///*целое натуральное число число - 8 байт*/
            //ulong ulo = 8;
            ///*одиночный символ в кодировке Unicode - 2 байта*/
            //char c = 'A';
            ///*число с плавающей точкой - 4 байта*/
            //float f = 3.4f;
            ///*число с плавающей точкой двойной точности - 8 байта*/
            //double d = 3e10;
            ///*набор символов unicode*/
            //string str = "Доброе утро!";
            ///*десятичное дробное число*/
            //decimal dec = 3.4m;

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            ////Вывод всех определенных переменных

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            //Console.WriteLine();
            //Console.WriteLine("                            <--------Вывод определенных заранее значений переменных-------->");
            //Console.WriteLine();
            //Console.WriteLine($"Логический тип данных bool: {b}");
            //Console.WriteLine($"Тип данных int: {i}");
            //Console.WriteLine($"Тип данных uint: {ui}");
            //Console.WriteLine($"Тип данных long: {l}");
            //Console.WriteLine($"Тип данных ulong: {ulo}");
            //Console.WriteLine($"Тип данных short: {sh}");
            //Console.WriteLine($"Тип данных ushort: {ush}");
            //Console.WriteLine($"Тип данных byte: {by}");
            //Console.WriteLine($"Тип данных sbyte: {sby}");
            //Console.WriteLine($"Тип данных decimal: {dec}");
            //Console.WriteLine($"Тип данных double: {d}");
            //Console.WriteLine($"Тип данных float: {f}");
            //Console.WriteLine($"Тип данных char: {c}");
            //Console.WriteLine($"Тип данных string: {str}");
            //Console.WriteLine();
            //Console.WriteLine();
            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            ////Ввод значений переменных и вывод их на консоль

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            //Console.WriteLine("Введите значения типа bool (true/false):");
            //b = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("Введите значение типа int:");
            //i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите значение типа uint:");
            //ui = Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine("Введите значение типа long:");
            //l = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Введите значение типа ulong:");
            //ulo = Convert.ToUInt64(Console.ReadLine());
            //Console.WriteLine("Введите значение типа short:");
            //sh = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Введите значение типа ushort:");
            //ush = Convert.ToUInt16(Console.ReadLine());
            //Console.WriteLine("Введите значение типа byte:");
            //by = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("Введите значение типа sbyte:");
            //sby = Convert.ToSByte(Console.ReadLine());
            //Console.WriteLine("Введите значение типа decimal:");
            //dec = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Введите значение типа double:");
            //d = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение типа float:");
            //f = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Введите значение типа char:");
            //c = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Введите значение типа string:");
            //str = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(); 
            //Console.WriteLine();



            //Console.WriteLine();
            //Console.WriteLine("                            <--------Вывод введенных с клавиатуры значений переменных-------->");
            //Console.WriteLine();
            //Console.WriteLine($"Логический тип данных bool: {b}");
            //Console.WriteLine($"Логический тип данных int: {i}");
            //Console.WriteLine($"Логический тип данных uint: {ui}");
            //Console.WriteLine($"Логический тип данных long: {l}");
            //Console.WriteLine($"Логический тип данных ulong: {ulo}");
            //Console.WriteLine($"Логический тип данных short: {sh}");
            //Console.WriteLine($"Логический тип данных ushort: {ush}");
            //Console.WriteLine($"Логический тип данных byte: {by}");
            //Console.WriteLine($"Логический тип данных sbyte: {sby}");
            //Console.WriteLine($"Логический тип данных decimal: {dec}");
            //Console.WriteLine($"Логический тип данных double: {d}");
            //Console.WriteLine($"Логический тип данных float: {f}");
            //Console.WriteLine($"Логический тип данных char: {c}");
            //Console.WriteLine($"Тип данных string: {str}");
            //Console.WriteLine();
            //Console.WriteLine();
            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            ////5 операций явного и неявного преобразования типов

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            //l = i;
            //i = sh;
            //ui = ush;
            //f = by;
            //d = sh;

            //Console.WriteLine();
            //Console.WriteLine("                            <--------Неявное приведение-------->");
            //Console.WriteLine();
            //Console.WriteLine($"int к long: {l}");
            //Console.WriteLine($"short к int: {i}");
            //Console.WriteLine($"ushort к uint: {ui}");
            //Console.WriteLine($"byte к float: {f}");
            //Console.WriteLine($"sbyte к double: {d}");
            //Console.WriteLine();
            //Console.WriteLine();


            //ulo = (ulong)ui;
            //by = (byte)c;
            //d = (double)f;
            //dec = (decimal)ush;
            //l = (long)sh;

            //Console.WriteLine();
            //Console.WriteLine("                            <--------Явное приведение-------->");
            //Console.WriteLine();
            //Console.WriteLine($"uint к ulong: {ulo}");
            //Console.WriteLine($"char к byte: {by}");
            //Console.WriteLine($"float к double: {d}");
            //Console.WriteLine($"ushort к decimal: {dec}");
            //Console.WriteLine($"sbyte к long: {l}");
            //Console.WriteLine();
            //Console.WriteLine();
            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            ////Упаковка и распаковка значимых типов

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            //int price = 39;
            //Console.WriteLine();
            //Object obj = price;
            //Console.WriteLine($"Упаковка: {obj}");
            //Console.WriteLine();
            //price = (int)obj;
            //Console.WriteLine($"Распаковка: {price}");
            //Console.WriteLine();
            //Console.WriteLine();
            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            ////Работа с неявно типизированной переменной и Nullable переменной + ошибка var

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            //var z = 5;
            //Console.WriteLine();
            //Console.WriteLine($"Неявно типизированная переменная: {z}");
            //Console.WriteLine();
            //int? nullable = null;
            //Console.WriteLine($"Объект чилового типа данных со значением null (Nullable - переменная):   {nullable}");
            //Console.WriteLine();
            //Console.WriteLine();

            //var error = 10;
            ////error = 3.6f; 
            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            ////Сравнение строковых литералов

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            //Console.WriteLine();
            //Console.WriteLine("                            <--------Сравнение строковых литералов-------->");
            //Console.WriteLine();
            //string str1, str2;
            //Console.WriteLine("Введите первую строку: ");
            //str1 = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Введите вторую строку: ");
            //str2 = Console.ReadLine();
            //int result = String.Compare(str1, str2);
            //if (result < 0)
            //{
            //    Console.WriteLine("Строка str1 перед строкой str2");
            //}
            //else if (result > 0)
            //{
            //    Console.WriteLine("Строка str1 стоит после строки str2");
            //}
            //else
            //{
            //    Console.WriteLine("Строки str1 и str2 идентичны");
            //}
            //string str_concat = String.Concat(str2, "!!!");
            //string str3 = null;
            //string str4, str5;
            //Console.WriteLine("Введите строку: ");
            //str3 = Console.ReadLine();
            //Console.WriteLine("Введите строку: ");
            //str4 = Console.ReadLine();
            //Console.WriteLine("Введите строку: ");
            //str5 = Console.ReadLine();
            //Console.WriteLine($"Интерполяция: {str3}");
            //str4 = String.Copy(str3);
            //Console.WriteLine($"Копирование: {str4}");
            //int n = 0;
            //bool flag = true;
            //Console.WriteLine("Индекс символ, начиная с которого вставляется строка: ");
            //while (flag)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n < str4.Length)
            //    {
            //        flag = false;
            //    }
            //    else Console.WriteLine("Неверный ввод! Повторите снова!");
            //}

            //str4 = str4.Substring(n);
            //Console.WriteLine($"Полученная подстрока: {str4}");
            //Console.WriteLine("Введите текст:");
            //str5 = Console.ReadLine();
            //string[] words = str5.Split(' ');
            //Console.WriteLine("Слова, полученные после разбиения строки");
            //foreach (string s in words)
            //{
            //    Console.WriteLine(s);
            //}
            //flag = true;

            //Console.WriteLine("Введите индекс позиции, с которой будет вставляться подстрока: ");
            //while (flag)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n < str5.Length)
            //    {
            //        flag = false;
            //    }
            //}
            //str5 = str5.Insert(n, str3);
            //Console.WriteLine($"Третья строка после вставки в нее подстроки: {str5}");
            //str5 = str5.Remove(n, str3.Length);
            //Console.WriteLine($"Третья строка после удаления из нее подстроки: {str5}");

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            ////Массивы

            ////<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            //Матрица
            Console.WriteLine("Матрица:");
            int[,] MatrixArr = new int[4, 4];
            Random Elem = new Random();
            for (int I = 0; I < 4; I++)
            {
                for (int j = 0; j < 4; j++)
                {
                    MatrixArr[I, j] = Elem.Next(1, 10);
                    Console.Write("{0}  ", MatrixArr[I, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Массив строк 

            string[] greetings = new string[] { "How", "are", "you?" };

            foreach (string m in greetings)
            {
                Console.Write(m + " ");
            }

            //Вычисление длины массива строк

            Console.WriteLine($"Длина массива: {greetings.Length}");


            Console.WriteLine();
            bool flag1 = true;

            //Изменение массива строк 

            Console.WriteLine("Введите индекс строки в массиве, которую вы хотите заменить (0, 1, 2):");

            int n = Convert.ToInt32(Console.ReadLine());

            while (flag1)
            {
                
                if (n < greetings.Length)
                {
                    flag1 = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Введите новую строку:");
            string str = Console.ReadLine();

            for (int counter1 = 0; counter1 < greetings.Length; counter1++)
            {
                if (counter1 == n)
                {
                    greetings[counter1] = str;
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Измененный массив:");

            foreach (string m in greetings)
            {
                Console.Write(m + " ");
            }





            Console.WriteLine();

            //Ступенчатый массив 2,3,4
            Console.WriteLine();
            Console.WriteLine("Ступенчатый массив:");
            int i = 0;
            // Объявляем ступенчатый массив
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
           

            // Инициализируем ступенчатый массив
            for (; i < 2; i++)
            {
                myArr[0][i] = i;
                Console.Write($"{myArr[0][i],2}");
            }

            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                myArr[1][i] = i;
                Console.Write($"{myArr[1][i],2}");
            }

            Console.WriteLine();
            for (i = 0; i < 4; i++)
            {
                myArr[2][i] = i;
                Console.Write($"{myArr[2][i],2}");
            }
            Console.WriteLine();

            //Неявно типизированные переменные для хранения строки и массива
            Console.WriteLine();
            var varStr = "Good morning!";
            Console.WriteLine($"Неявно типизированная переменная для хранения данных типа String: {varStr}");
            Console.WriteLine();
            var varArr = new[] { 2, 3, 4 };
            Console.WriteLine("Неявно типизированная переменная для хранения массива: {0}, {1}, {2}", varArr[0], varArr[1], varArr[2]);
            Console.WriteLine();



        }




    }
}