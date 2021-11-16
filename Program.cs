using Autofac;
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
            var builder = new ContainerBuilder();
            builder.RegisterType<GenerateScannerFile>().As<IGenerateScannerFile>();
            builder.RegisterType<PCEfficiency>().As<IPCEfficiencycs>();
            builder.RegisterType<Scanner>().As<IScanner>();
            builder.RegisterType<MainLibraryClass>().As<IMainLibraryClass>();

            IContainer container = builder.Build();

            IGenerateScannerFile generateScannerService = container.Resolve<IGenerateScannerFile>();
            IPCEfficiencycs EfficiencyService = container.Resolve<IPCEfficiencycs>();
            IScanner ScannerService = container.Resolve<IScanner>();
            IMainLibraryClass MainLibraryService = container.Resolve<IMainLibraryClass>();

            generateScannerService.GenerateScannerData();

            dataModelDTO dataModelDTO = new dataModelDTO();

            string [] GetScannerData = ScannerService.ReadScanner();
            for (int i=0; i<10; i++)
            {
                dataModelDTO.ID = Encoding.ASCII.GetBytes(GetScannerData[i]);
                dataModelDTO.CPULoad = Encoding.ASCII.GetBytes(Convert.ToString(EfficiencyService.GetCPULOad()));
                dataModelDTO.MemoryLoad = Encoding.ASCII.GetBytes(Convert.ToString(EfficiencyService.GetMemoryLoad()));
                MainLibraryService.GetData(dataModelDTO);
            }         
        }
    }
}
