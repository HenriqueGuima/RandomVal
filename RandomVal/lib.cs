using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RandomVal
{
    class lib
    {
        public static void StartProcess(string process)
        {
            Process.Start(process);
        }

        public static void StartExcelProcess(string excelprocess)
        {
            System.Diagnostics.Process.Start(@"c:\Users\Guima\Desktop\" + excelprocess + ".ods");

        }
    }
}
