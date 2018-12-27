using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int b;
            bool c;
            char d;
            double e;

            //

            a = "Привет";
            b = 234;
            c = true;
            d = 'f';
            e = 34.43;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.WriteLine();

            //

            string aa = (string)a;
            int bb = (int)b;
            bool cc = (bool)c;
            char dd = (char)d;
            double ee = (double)e;
            Console.WriteLine("aa = " + aa);
            Console.WriteLine("bb = " + bb);
            Console.WriteLine("cc = " + cc);
            Console.WriteLine("dd = " + dd);
            Console.WriteLine("ee = " + ee);
            Console.WriteLine();

            //
            
            int i = 123;
            object o = i;
            o = 123;
            i = (int)o;
            Console.WriteLine("i = " + i);
            Console.WriteLine("o = " + o);
            Console.WriteLine();

            //

            var j = 34;
            Console.WriteLine("j = " + j);
            Console.WriteLine();

            //

            int? g = null;
            Console.WriteLine("g = " + g);
            Console.WriteLine();

            //

            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(-11);
            Console.WriteLine(5);
            Console.WriteLine(505);
            Console.WriteLine();

            //

            string sad = "hello";
            string dsf = "world";
            string dfh = "!";
            string text = "1 2 3 4 5";
            string[] words = text.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(sad + dsf);
            Console.WriteLine(dfh = dsf);
            Console.WriteLine();

            //

            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine("2" + sb + "!");
            Console.WriteLine();

            //

            string sdg = "";
            string asf = null;
            Console.WriteLine(sdg + asf);
            Console.WriteLine(asf);
            Console.WriteLine();
            Array a1 = new Array[4];

            //---------------------

            Console.ReadKey();
        }
    }
}