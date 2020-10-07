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
            //Определение переменных всех возможных примитивных типов

            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            /*целое число - 4 байта*/
            int i = -4;
            /*логический литерал*/
            bool b = false;
            /*целое число - 2 байта*/
            short s = 2;
            /*целое натуральное число число - 1 байт*/
            byte by = 1;
            /*целое число - 1 байт*/
            sbyte sby = -1;
            /*целое натуральное число - 2 байта*/
            ushort ush = 2;
            /*целое натуральное число число - 4 байта*/
            uint ui = 4;
            /*целое число - 8 байт*/
            long l = 8;
            /*целое натуральное число число - 8 байт*/
            ulong ulo = 8;
            /*одиночный символ в кодировке Unicode - 2 байта*/
            char c = 'A';
            /*число с плавающей точкой - 4 байта*/
            float f = 3.4f;
            /*число с плавающей точкой двойной точности - 8 байта*/
            double d = 3e10;
            /*набор символов unicode*/
            string str = "Доброе утро!";
            /*десятичное дробное число*/
            decimal dec = 3.4m;
            
            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            //Вывод всех определенных переменных

            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            Console.WriteLine();
            Console.WriteLine("                            <--------Вывод определенных заранее значений переменных-------->");
            Console.WriteLine();
            Console.WriteLine($"Логический тип данных bool: {b}");
            Console.WriteLine($"Тип данных int: {i}");
            Console.WriteLine($"Тип данных uint: {ui}");
            Console.WriteLine($"Тип данных long: {l}");
            Console.WriteLine($"Тип данных ulong: {ulo}");
            Console.WriteLine($"Тип данных short: {s}");
            Console.WriteLine($"Тип данных ushort: {ush}");
            Console.WriteLine($"Тип данных byte: {by}");
            Console.WriteLine($"Тип данных sbyte: {sby}");
            Console.WriteLine($"Тип данных decimal: {dec}");
            Console.WriteLine($"Тип данных double: {d}");
            Console.WriteLine($"Тип данных float: {f}");
            Console.WriteLine($"Тип данных char: {c}");
            Console.WriteLine($"Тип данных string: {str}");
            Console.WriteLine();
            Console.WriteLine();
            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            //Ввод значений переменных и вывод их на консоль

            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            Console.WriteLine("Введите значения типа bool (true/false):");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введите значение типа int:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение типа uint:");
            ui = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите значение типа long:");
            l = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите значение типа ulong:");
            ulo = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Введите значение типа short:");
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите значение типа ushort:");
            ush = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введите значение типа byte:");
            by = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите значение типа sbyte:");
            sby = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите значение типа decimal:");
            dec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите значение типа double:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение типа float:");
            f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите значение типа char:");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите значение типа string:");
            str = Convert.ToString(Console.ReadLine());
            Console.WriteLine(); 
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("                            <--------Вывод введенных с клавиатуры значений переменных-------->");
            Console.WriteLine();
            Console.WriteLine($"Логический тип данных bool: {b}");
            Console.WriteLine($"Логический тип данных int: {i}");
            Console.WriteLine($"Логический тип данных uint: {ui}");
            Console.WriteLine($"Логический тип данных long: {l}");
            Console.WriteLine($"Логический тип данных ulong: {ulo}");
            Console.WriteLine($"Логический тип данных short: {s}");
            Console.WriteLine($"Логический тип данных ushort: {ush}");
            Console.WriteLine($"Логический тип данных byte: {by}");
            Console.WriteLine($"Логический тип данных sbyte: {sby}");
            Console.WriteLine($"Логический тип данных decimal: {dec}");
            Console.WriteLine($"Логический тип данных double: {d}");
            Console.WriteLine($"Логический тип данных float: {f}");
            Console.WriteLine($"Логический тип данных char: {c}");
            Console.WriteLine($"Тип данных object: {obj}");
            Console.WriteLine($"Тип данных string: {str}");
            Console.WriteLine();
            Console.WriteLine();
            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            //5 операций явного и неявного преобразования типов

            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            l = i;
            i = s;
            ui = ush;
            f = by;
            d = s;

            Console.WriteLine();
            Console.WriteLine("                            <--------Неявное приведение-------->");
            Console.WriteLine();
            Console.WriteLine($"int к long: {l}");
            Console.WriteLine($"short к int: {i}");
            Console.WriteLine($"ushort к uint: {ui}");
            Console.WriteLine($"byte к float: {f}");
            Console.WriteLine($"sbyte к double: {d}");
            Console.WriteLine();
            Console.WriteLine();


            ulo = (ulong)ui;
            by = (byte)c;
            d = (double)f;
            dec = (decimal)ush;
            l = (long)s;

            Console.WriteLine();
            Console.WriteLine("                            <--------Явное приведение-------->");
            Console.WriteLine();
            Console.WriteLine($"uint к ulong: {ulo}");
            Console.WriteLine($"char к byte: {by}");
            Console.WriteLine($"float к double: {d}");
            Console.WriteLine($"ushort к decimal: {dec}");
            Console.WriteLine($"sbyte к long: {l}");
            Console.WriteLine();
            Console.WriteLine();
            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->


            //Упаковка и распаковка значимых типов

            //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
            int price = 39;
            Console.WriteLine();
            Object obj = price;
            Console.WriteLine($"Упаковка: {obj}");
            Console.WriteLine();
            price = (int)obj;
            Console.WriteLine($"Распаковка: {price}");
            Console.WriteLine();
            

        }


    }
}