using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PifagorsTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(100, 300);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            tableContent();
            tableHead();

            Console.ReadKey();
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

        static void tableContent()
        {
            //содержимое таблицы
            for (int i = 1; i <= 10; i++)
            {

                strPrint(strFormat(i));

                for (int j = 1; j <= 10; j++)
                {
                    strPrint(strFormat(i * j));
                }

                strPrint("\n");
            }
        }


    }
}
