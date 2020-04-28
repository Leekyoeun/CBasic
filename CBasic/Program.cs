using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "이" + "교" + "은";
            Console.Write("Hello C#");
            int add= 2;
            int Alpha;
            //주석
            /*
             * 여러줄 주석
             */
            Console.WriteLine("Hello World"); //행 바꿈
            Console.Write("Hello World");//행 안바꿈
            Console.Write("hello world");

            Console.Write(52);
            Console.WriteLine(7 % 3);
            Console.WriteLine('A');
            Console.WriteLine('A');

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("가" + "나" + "다");

            Console.WriteLine("안녕"[100]);

            Console.WriteLine(true);
            Console.WriteLine(true);

        }
    }
}
