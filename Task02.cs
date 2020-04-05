using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Task02
    {
        static void Main(string[] args)
        {
            OperatorOverloading A = new OperatorOverloading(25);
            OperatorOverloading B = new OperatorOverloading(10);

            Console.WriteLine("Арифметические действия над объектами класса OperatorOverloading");
            Console.WriteLine("Результат сложения: " + (A + B));
            Console.WriteLine("Результат вычитания: " + (A - B));
            Console.WriteLine("Результат умножения: " + (A * B));

            Console.WriteLine("Арифметические действия над объектами класса OperatorOverloading");
            Console.WriteLine("с использованием сокращенных форм операторов присваивания");
            Console.WriteLine("Результат сложения: " + (A += B).field);
            Console.WriteLine("Результат вычитания: " + (A -= B).field);
            Console.WriteLine("Результат умножения: " + (A *= B).field);

            Console.Read();
        } 
    }

    class OperatorOverloading
    {
        public int field;

        public OperatorOverloading(int n)
        {
            field = n;
        }

        public static implicit operator OperatorOverloading(int num)
        {
            return new OperatorOverloading(num);
        }


        public static int operator+(OperatorOverloading a, OperatorOverloading b)
        {
            int sum = a.field + b.field;
            return sum;
        }

        public static int operator-(OperatorOverloading a, OperatorOverloading b)
        {
            int dif = a.field - b.field;
            return dif;
        }

        public static int operator*(OperatorOverloading a, OperatorOverloading b)
        {
            int res = a.field * b.field;
            return res;
        }

    }
}
