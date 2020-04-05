using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class Task08
    {
        static void Main(string[] args)
        {
            BaseClass obj01 = new BaseClass("Hello");
            Console.WriteLine("Значение поля класса BaseClass: " + obj01.text);
            obj01.text = "World";
            Console.WriteLine("Значение поля класса BaseClass: " + obj01.text);

            Console.WriteLine();

            SubClass obj02 = new SubClass("Hello", "World");
            Console.WriteLine("Значение поля класса SubClass: " + obj02.text);
            obj02.text = "Helloworld";
            Console.WriteLine("Значение поля класса SubClass: " + obj02.text);
            obj02.text = "Hello world";
            Console.WriteLine("Значение поля класса SubClass: " + obj02.text);

            Console.Read();
        }


    }

    class BaseClass
    {
        private string field01;

        public BaseClass(string str)
        {
            field01 = str;
        }

        public virtual string text
        {
            get
            {
                return field01;
            }
            set
            {
                field01 = value;
            }
        }

        public override string ToString()
        {
            return "BaseClass" + field01;
        }
    }

    class SubClass: BaseClass
    {
        public string field02;

        public SubClass(string str1, string str2): base(str1)
        {
            field02 = str2;
        }

        public override string text
        {
            get
            {
                return base.text + " | " + field02 + " | ";
            }
            set
            {
                if (value.IndexOf(" ") != -1)
                {
                    int delimiter = value.IndexOf(" ");
                    int l = value.Length;
                    base.text = value.Substring(0, delimiter);
                    field02 = value.Substring(0, l);
                }
                else
                {
                    base.text = value;
                    field02 = "";
                }
            }
        }

        public override string ToString()
        {
            return "SubClass" + base.text + " " + field02;
        }
    }


}
