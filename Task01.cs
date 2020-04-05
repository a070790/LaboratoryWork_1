using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Task01
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4 };
            OperatorOverloading A = new OperatorOverloading(array);

            Console.WriteLine("Преобразование объекта A к типу String:");
            Console.WriteLine("Строка со значениями массива: " + (String)A);

            Console.WriteLine("Преобразование объекта A к типу int:");
            Console.WriteLine("Число - сумма элементов массива: " + (int)A);

            OperatorOverloading B = 20;
            Console.WriteLine("Строка со значениями массива: " + (String)B);

            Console.Read();
        }
    }

    class  OperatorOverloading
    {
        public int[] field;

        public OperatorOverloading(int[] refer)
        {
            field = refer;
        }

        public OperatorOverloading(int pr)
        {
            field = new int[pr];
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = 0;
            }
        }

        public static explicit operator String(OperatorOverloading obj)
        {
            String text = "";
            for (int i = 0; i < obj.field.Length; i++)
            {
                text += obj.field[i] + " ";
            }

            return text;
        }

        public static explicit operator int(OperatorOverloading obj)
        {
            int sum = 0;
            for (int i = 0; i < obj.field.Length; i++)
            {
                sum += obj.field[i];
            }

            return sum;
        }

        public static implicit operator OperatorOverloading(int n)
        {
            OperatorOverloading obj = new OperatorOverloading(n);
            return obj;
        }
    }
}
