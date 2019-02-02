using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPifagorsTable
{
    class Program
    {

        static void Main(string[] args)
        {
            strPrint("Выберите СС: 2, 8, 10, 16 \n");
            int ss = 10;
            switch (Console.ReadLine())
            {
                case "2": ss = 2;break;
                case "8": ss = 8;break;
                case "10": ss = 10; break;
                case "16": ss = 16; break;
            }

            Console.SetBufferSize(100, 300);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            tableHead();
            tableContent(ss);

            Console.ReadKey();
        }

        static string strFormat(int number, int ss)
        {
            string str = Convert.ToString(number, ss);
            str = String.Format($"\t{str}");
            return str;
        }

        static string strFormat(int number)
        {
            string str = String.Format($"\t{number:d2}");
            return str;
        }

        static void strPrint(string str)
        {
            Console.Write(str);
        }

        static void tableHead()
        {
            //шапка таблицы
            strPrint("\n\t");
            for (int i = 1; i <= 10; i++)
                strPrint(strFormat(i));
            strPrint("\n\n");
        }

        static void tableContent(int ss)
        {
            //содержимое таблицы
            for (int i = 1; i <= 10; i++)
            {

                strPrint(strFormat(i));

                for (int j = 1; j <= 10; j++)
                {
                    strPrint(strFormat(i * j, ss));
                }

                strPrint("\n");
            }
        }
    }
}
