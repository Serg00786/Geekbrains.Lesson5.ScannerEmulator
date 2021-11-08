using ReadScannerLibrary;
using ReadScannerLibrary.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Geekbrains.Lesson5.ScannerEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenerateScannerFile generateScannerFile = new GenerateScannerFile();
            generateScannerFile.GenerateScannerData();
            IScanner scanner = new Scanner();
            dataModelDTO dataModelDTO = new dataModelDTO();

            IPCEfficiencycs Efficiency = new PCEfficiency();
            MainLibraryClass mainLibraryClass = new MainLibraryClass();

            string [] GetScannerData = scanner.ReadScanner();
            for (int i=0; i<10; i++)
            {
                dataModelDTO.ID = Encoding.ASCII.GetBytes(GetScannerData[i]);
                dataModelDTO.CPULoad = Encoding.ASCII.GetBytes(Convert.ToString(Efficiency.GetCPULOad()));
                dataModelDTO.MemoryLoad = Encoding.ASCII.GetBytes(Convert.ToString(Efficiency.GetMemoryLoad()));
                mainLibraryClass.GetData(dataModelDTO);
            }

            

        }
    }
}
