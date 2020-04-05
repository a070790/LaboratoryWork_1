using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    public class Task06
    {
        static void Main(string[] args)
        {
            ClassWithIndexer obj = new ClassWithIndexer(3);
            obj[0] = "Hello";
            obj[1] = ", ";
            obj[2] = "world!";

            Console.WriteLine("Ввод и вывод значений текстового массива из класса ClassWithIndexer");
            Console.WriteLine("с использованием методов индексатора set и get соответственно");
            for (int i = 0; i < obj.length; i++)
            {
                Console.Write(obj[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Применение индексатора с двумя индексами к элементу текстового массива");
            Console.WriteLine("для вывода символа из строки с соответствующим индексом в строке");
            Console.WriteLine(obj[2,0]);
       
            Console.Read();
        }
    }

    class ClassWithIndexer
    {
        private string[] field;

        public ClassWithIndexer(int n)
        {
            field = new string[n];
        }

        public int length
        {
            get
            {
                return field.Length;
            }
        }

        public string this[int k]
        {
            get
            {
                return field[k % field.Length];
            }
            set
            {
                field[k % field.Length] = value;
            }
        }

        public char this[int k, int indexChar]
        {
            get
            {
                return (field[k])[indexChar];
            }
        }
    }
}
