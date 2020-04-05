using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    public class Task07
    {
        static void Main(string[] args)
        {
            BaseClass obj01 = new BaseClass(23456);
            Console.WriteLine("Цифра в 3-м разряде числа: " + obj01[3]);

            SubClass obj02 = new SubClass(512, 512);
            Console.WriteLine("Цифра в 1-м разряде числа из поля базового класса: " + obj02[1,1]);
            Console.WriteLine("Цифра в 2-м разряде числа из поля подкласса: " + obj02[2, 2]);

            Console.WriteLine("Цифра в 3-м разряде числа из суммы полей: " + obj02[3]);
            Console.Read();
        }
    }

    class BaseClass
    {
        public int field01;

        public BaseClass(int n)
        {
            field01 = n;
        }

        public int this[int k]
        {
            get
            {
                int num = field01;
                for (int i = 0; i < k; i++)
                {
                    num /= 10;
                }
                num %= 10;
                return num;
            }
        }
    }

    class SubClass: BaseClass
    {
        public int field02;

        public SubClass(int n1, int n2): base(n1)
        {
            field02 = n2;
        }

        public int this[int k1, int k2]
        {
            get
            {
                int num = 0;
                if(k1 == 1)
                {
                    num = field01;
                    for (int i = 0; i < k2; i++)
                    {
                        num /= 10;
                    }
                    num %= 10;
                }
                if(k1 == 2)
                {
                    num = field02;
                    for (int i = 0; i < k2; i++)
                    {
                        num /= 10;
                    }
                    num %= 10;
                }
                return num;
            }
        }

        public int this[int k]
        {
            get
            {
                int num = field01 + field02;
                for (int i = 0; i < k; i++)
                {
                    num /= 10;
                }
                num %= 10;
                return num;
            }
        }
    } 
}
