using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains.Lesson5.ScannerEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateScannerFile generateScannerFile = new GenerateScannerFile();
            generateScannerFile.GenerateScannerData();
        }
    }
}
