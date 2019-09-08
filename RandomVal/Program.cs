using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace RandomVal
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;

            do
            {
                string _process = Console.ReadLine();

                try
                {
                    lib.StartProcess(_process);
                }
                catch (Exception)
                {
                    lib.StartExcelProcess(_process);
                }

                Console.ReadKey();

            } while (op != 0);
        }
    }
}
