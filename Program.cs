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

            //

            int[,] a1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int k = 0; k < a1.GetLength(0); k++)
            {
                for (int h = 0; h < a1.GetLength(0); h++)
                {
                    Console.Write(a1[k, h] + "\t");
                }
                Console.WriteLine();
            }
            string[] a2 = new string[3] { "К 1", "с 2", "о 3" };
            for (int k = 0; k < a1.GetLength(0); k++)
            {
                Console.Write(a2[k] + "; ");
            }
            Console.WriteLine();
            string a3, a4;
            int a5, a6;
            a3 = Console.ReadLine();
            a4 = Console.ReadLine();
            a5 = Convert.ToInt32(a3) - 1;
            a6 = Convert.ToInt32(a4) - 1;
            a3 = a2[a5];
            a2[a5] = a2[a6];
            a2[a6] = a3;
            for (int k = 0; k < a1.GetLength(0); k++)
            {
                Console.Write(a2[k] + "; ");
            }
            Console.WriteLine();
            double[][] b1 = new double[3][];
            b1[0] = new double[2] { 1.2, 2.3};
            b1[1] = new double[3] { 1.2, 2.3, 3.4 };
            b1[2] = new double[4] { 1.2, 2.3, 3.4, 4.5 };
            for (int k = 0; k < b1.Length; k++)
            {
                for (int l = 0; l < b1[k].Length; l++)
                {
                    Console.Write(b1[k][l] + "\t");
                }
                Console.WriteLine();
            }
            var с1 = new object[0];
            var с2 = "";
            Console.WriteLine();

            //

            (int, string, char, string, ulong) d1 = (1, "2", '3', "4", 5);
            Console.WriteLine(d1.Item1 + "; " + d1.Item2 + "; " + d1.Item3 + "; " + d1.Item4 + "; " + d1.Item5 + ".");
            Console.WriteLine(d1.Item1 + "; " + d1.Item3 + "; " + d1.Item4 + ".");
            int d3 = d1.Item1;
            string d4 = d1.Item2;
            char d5 = d1.Item3;
            string d6 = d1.Item4;
            ulong d7 = d1.Item5;

            //---------------------

            Console.ReadKey();
        }
    }
}
