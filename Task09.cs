using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    public class Task09
    {
        static void Main(string[] args)
        {
            BaseClass obj01 = new BaseClass(10);
            Console.WriteLine("Заполнение целочисленного массива базового класса");
            for (int i = 0; i < obj01.length; i++)
            {
                obj01[i] = i * i;
                Console.Write(obj01[i] + " ");
            }
            Console.WriteLine();

            SubClass obj02 = new SubClass(5, 5);
            Console.WriteLine("Примение замещающего свойства length из класса-наследника");
            Console.Write(obj02.length[0] + " " + obj02.length[1]);
            Console.Read();
        }
    }

    class BaseClass
    {
        protected int[] field01;

        public BaseClass(int size)
        {
            field01 = new int[size];
        }

        public virtual int this[int k]
        {
            get
            {
                return field01[k];
            }
            set
            {
                field01[k] = value;
            }
        }
        
        public virtual int length
        {
            get
            {
                return field01.Length;
            }
               
        }
    }

    class SubClass: BaseClass
    {
        protected char[] field02;

        public SubClass(int intSize, int charSize): base(intSize)
        {
            field02 = new char[charSize];
        }

        public int this[char index]
        {
            get
            {
                return field02[index - 'a'];
            }
            set
            {
                field02[index - 'a'] = (char)value;
            }
        }

        public virtual int[] length
        {
            get
            {
                int[] array = new int[2];
                array[0] = base.length;
                array[1] = this.field02.Length;
                return array;
            }

        }
    }

}
