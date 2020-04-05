using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Task04
    {
        static void Main(string[] args)
        {
            ClassWithIndexer obj = new ClassWithIndexer();
            obj[0] = 1234;
            Console.WriteLine(obj.field);
            obj[1] = 1234;
            Console.WriteLine(obj.field);
            obj[2] = 1234;
            Console.WriteLine(obj.field);
            obj[3] = 1234;
            Console.WriteLine(obj.field);

            Console.Read();
        }
    }

    class ClassWithIndexer
    {
        public int field;

        public int this[int k]
        {
            set
            {
                int num = value;
                for(int i = 0; i < k; i++)
                {
                    num /= 10;
                }
                num %= 10;
                field = num;
            }
        }
    }
}
