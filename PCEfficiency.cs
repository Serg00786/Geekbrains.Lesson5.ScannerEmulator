using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains.Lesson5.ScannerEmulator
{
    public interface IPCEfficiencycs
    {
        int GetCPULOad();
        int GetMemoryLoad();

    }
    class PCEfficiency : IPCEfficiencycs
    {
        Random rnd = new Random();

        public int GetCPULOad()
        {
            return rnd.Next(1, 100);
        }

        public int GetMemoryLoad()
        {
            return rnd.Next(1, 4096);
        }
    }
}
