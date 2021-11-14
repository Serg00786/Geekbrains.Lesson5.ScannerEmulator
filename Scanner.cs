using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains.Lesson5.ScannerEmulator
{
    public interface IScanner
    {
        string[] ReadScanner();
    }
    class Scanner : IScanner
    {
        public string[] ReadScanner()
        {

            string[] lines = System.IO.File.ReadAllLines(@"Scanner.txt");
            return lines;
        }

    }
}
