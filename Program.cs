using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    partial class Book
    {
        private readonly int id;
        private string title;
        private string author;
        private string publishingHouse;
        private ushort year;
        private uint pageNumber;
        private uint cost;
        private string blindingType;

        static int counterObj = 0;

        static void classInfo()
        {
            Console.WriteLine(counterObj);

        }





        public Book(string title, string author, string publishingHouse, ushort year, uint pageNumber, uint cost, string blindingType)
        {

            this.title = title;
            this.author = author;
            this.publishingHouse = publishingHouse;
            this.year = year;
            this.pageNumber = pageNumber;
            if (cost > 0)
                this.cost = cost;
            else
                Console.WriteLine("Цена не может быть отрицательной");
            this.blindingType = blindingType;

            id = (int)(Year * Cost) % 7;
            counterObj++;

        }

        //private Book()
        //{
        //    Console.WriteLine("Закрытый конструктор");

        //}




        public int Id
        {
            get
            {
                if (id > 0)
                    return id;
                else return 0;

            }

        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        public string Author
        {
            get { return author; }
            set { author = value; }
        }



        public string PublishingHouse
        {
            get { return publishingHouse; }
            set { publishingHouse = value; }
        }



        public ushort Year
        {

            get { return year; }
            set
            {
                if (year <= 2019)
                    year = value;
                else year = 0;
            }
        }



        public uint PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }



        public uint Cost
        {
            get { return cost; }
            set { cost = value; }
        }


        public string BlindingType
        {
            get { return blindingType; }
            set { blindingType = value; }
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            string str2 = "123";
            int b = 7;
           
            if (str1==str2)
            {
                Console.WriteLine("++++++++++++++++++++++++");
            }
            Console.WriteLine("Сколько книг будет в вашей библиотеке?");
            sbyte counter = sbyte.Parse(Console.ReadLine());

            Book[] library = new Book[counter];
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"Создаём {i + 1} книгу:");
                library[i] = new Book();
                Console.WriteLine("Введите название книги:");
                library[i].Title = Console.ReadLine();
                Console.WriteLine("Введите автора книни:");
                library[i].Author = Console.ReadLine();
                Console.WriteLine("Введите издательство:");
                library[i].PublishingHouse = Console.ReadLine();
                Console.WriteLine("Введите год издания:");
                library[i].Year = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер страницы:");
                library[i].PageNumber = uint.Parse(Console.ReadLine());
                Console.WriteLine("Введите цену:");
                library[i].Cost = uint.Parse(Console.ReadLine());
                Console.WriteLine("Введите тип переплёта:");
                library[i].BlindingType = Console.ReadLine();


            }
            Console.WriteLine(library[0].ToString());

            Console.WriteLine("Введите автора книги, книги которого нужно найти:");
            string checkAuthor = Console.ReadLine();
            for (int i = 0; i < counter; i++)
            {
                if (library[i].Author == checkAuthor)
                {
                    Console.WriteLine("Найдена книга {0}", library[i].Title);

                }


                Console.WriteLine("Введите год, после которого будет выведен список книг:");
                ushort checkYear = ushort.Parse(Console.ReadLine());

                for (int j = 0; j < counter; j++)
                {
                    if (library[j].Year > checkYear)
                        Console.WriteLine("Найдена книга {0} {1} года", library[j].Title, library[j].Year);


                }

                Book test1 = new Book("forest", "Dima", "Minsk", 2001, 241, 44, "тонкий");
                Console.WriteLine(test1.GetHashCode());
                Console.WriteLine(test1.GetType());
                Console.WriteLine(test1.Id);

                Book test2 = new Book();
                Console.WriteLine(test1.Equals(test2));


                var user = new { Name = "Tom", Age = 34 }; // анонимный тип
                Console.WriteLine(user.Name);
            }
        }
    }
}
