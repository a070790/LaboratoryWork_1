using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Task03
    {
        static void Main(string[] args)
        {
            OperatorOverloading A = new OperatorOverloading('A');
            OperatorOverloading B = new OperatorOverloading('B');

            Console.WriteLine("Применения операторов +/- к объектам класса OperatorOverloading");
            Console.WriteLine("Результат применения оператора + : " + (A + B));
            Console.WriteLine("Результат применения оператора - : " + (A - B));

            Console.WriteLine("Применения операторов +/- к объектам класса OperatorOverloading");
            Console.WriteLine("с использованием сокращенных форм операторов присваивания");
            Console.WriteLine("Результат применения оператора + : " + (A += B).field02);
            A = new OperatorOverloading('A');
            Console.WriteLine("Результат применения оператора - : " + (A -= B).field03);

            Console.Read();
        }
    }

    class OperatorOverloading
    {
        public char field;
        public string field02;
        public int field03;

        public OperatorOverloading(char ch)
        {
            field = ch;
        }

        public OperatorOverloading(string str)
        {
            field02 = str;
        }

        public OperatorOverloading(int num)
        {
            field03 = num;
        }

        public static implicit operator OperatorOverloading(string pr)
        {
            return new OperatorOverloading(pr);
        }

        public static implicit operator OperatorOverloading(int pr)
        {
            return new OperatorOverloading(pr);
        }

        public static string operator+(OperatorOverloading a, OperatorOverloading b)
        {
            string str = a.field + " " + b.field;
            return str;
        }

        public static int operator-(OperatorOverloading a, OperatorOverloading b)
        {
            int codeDif = (int)a.field - (int)b.field;
            return codeDif;
        }
    }
}
