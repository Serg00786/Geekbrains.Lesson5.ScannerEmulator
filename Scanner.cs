using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains.Lesson5.ScannerEmulator
{
    class Scanner : IScanner
    {
        public string[] ReadScanner()
        {
            //byte[] result = new byte[10];
            string[] lines = System.IO.File.ReadAllLines(@"Scanner.txt");
            //for (int i=0; i<10; i++)
            //{
            //    result[i]=Convert.ToByte(lines[i]);
            //}

            return lines;
        }

    }
}
