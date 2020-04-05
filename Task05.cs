using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Task05
    {
        static void Main(string[] args)
        {
            ClassWithIndexer obj = new ClassWithIndexer(5, 5);
            Random rnd = new Random();

            Console.WriteLine("Исходный двумерный массив из класса ClassWithIndexer,");
            Console.WriteLine("рандомно заполненный с помощью метода set двумерного индексатора класса ClassWithIndexer");
            Console.WriteLine("и выведенный на консоль с помощью метода get двумерного индексатора класса ClassWithIndexer");
            for (int i = 0; i < obj.lengthOfLine; i++)
            {
                for(int j = 0; j < obj.lengthOfColumn; j++)
                {
                    obj[i, j] = rnd.Next(100);
                    Console.Write(obj[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Ввод нового значения в 3-ю строку двумерного массива");
            Console.WriteLine("с помощью метода set одномерного индексатора класса ClassWithIndexer");
            obj[3] = 234;

            Console.WriteLine();

            Console.WriteLine("Повторный вывод массива на консоль");
            for (int i = 0; i < obj.lengthOfLine; i++)
            {
                for (int j = 0; j < obj.lengthOfColumn; j++)
                {
                    Console.Write(obj[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Вывод на консоль значения эдемента из 2-й строки двумерного массива");
            Console.WriteLine("с помощью метода get одномерного индексатора класса ClassWithIndexer");
            Console.WriteLine(obj[2]);

            Console.Read();
        }
    }

    class ClassWithIndexer
    {
        private int[,] field;

        public ClassWithIndexer(int m, int n)
        {
            field = new int[m, n];
        }

        public int lengthOfLine
        {
            get
            {
                return field.GetLength(0);
            }
        }

        public int lengthOfColumn
        {
            get
            {
                return field.GetLength(1);
            }
        }

        public int this[int k]
        {
            get
            {
                int max = field[k, 0];
                for(int i = 1; i < field.GetLength(0); i++)
                {
                    if(max < field[k, i])
                    {
                        max = field[k, i];
                    }
                }
                return max;
            }
            set
            {
                for (int i = 1; i < field.GetLength(0); i++)
                {
                    int max = 0;
                    if (field[k, max] < field[k, i])
                    {
                        max = i;
                    }
                    field[k, max] = value;
                }
            }
        }

        public int this[int m, int n]
        {
            get
            {
                return field[m, n];
            }
            set
            {
                field[m, n] = value;
            }
        }

    }
}
